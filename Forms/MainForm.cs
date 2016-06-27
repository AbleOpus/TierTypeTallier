using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TierTypeTallier.FileTallying;
using TierTypeTallier.Properties;

namespace TierTypeTallier.Forms
{
    public partial class MainForm : Form
    {
        private readonly FileTallier tallier = new FileTallier();

        /// <summary>
        /// Gets or sets whether the cancel button is visible.
        /// </summary>
        private bool CancelButtonVisible
        {
            get { return buttonCancel.Visible; }
            set
            {
                buttonCancel.Visible = value;
                buttonRunTallier.Visible = !value;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            tallier.ProgressReport += (s, files) =>
                lblStatus.Text = $"Busy ({files} files iterated)";

            tallier.TallierCompleted += (sender, results) =>
            {
                lblStatus.Text = "Idle";
                PopulateTallyGrid(results);
                PopulateAdditionalInfoGrid(results);
                CancelButtonVisible = false;
                buttonExport.Enabled = (gridViewStats.Rows.Count > 0 || gridViewTypeTally.Rows.Count > 0);
                lblStatus.Text = results.Cancelled ? "Tallier cancelled" : "Tallier completed successfully";
            };

            // If the last path is empty, then set it to current drive
            if (String.IsNullOrEmpty(Settings.Default.LastPath))
                Settings.Default.LastPath = Path.GetPathRoot(Application.StartupPath);
            // Binds last path to its corresponding property
            pathPicker.DataBindings.Add("SelectedPath", Settings.Default, "LastPath");
        }

        /// <summary>
        /// Gets the general info as a string.
        /// </summary>
        private string GeneralInfoGridToString()
        {
            var SB = new StringBuilder();

            foreach (DataGridViewRow row in gridViewStats.Rows)
                SB.AppendLine($"{row.Cells[0].Value}: {row.Cells[1].Value}");

            return SB.ToString().TrimEnd();
        }

        /// <summary>
        /// Gets the file tallies as a string.
        /// </summary>
        private string FileTalliesToString()
        {
            var SB = new StringBuilder();

            foreach (DataGridViewRow row in gridViewTypeTally.Rows)
            {
                SB.AppendLine($"{row.Cells[2].Value}% ({row.Cells[1].Value}) of {row.Cells[0].Value}");
            }

            return SB.ToString();
        }

        /// <summary>
        /// Loads the file-type tally data grid view with data.
        /// </summary>
        private void PopulateTallyGrid(FileTallierResults results)
        {
            gridViewTypeTally.SuspendLayout();
            gridViewTypeTally.Rows.Clear();

            foreach (var tally in results.Tallies)
            {
                double percent = results.Statistics.GetPercent(tally);
                string strPercent = Math.Round(percent, 3) + "%";
                gridViewTypeTally.Rows.Add(tally.Extension, tally.Count, strPercent);
            }

            gridViewTypeTally.ResumeLayout();
        }

        /// <summary>
        /// Loads the general info data grid view with data.
        /// </summary>
        private void PopulateAdditionalInfoGrid(FileTallierResults results)
        {
            gridViewStats.Rows.Clear();
            gridViewStats.Rows.Add("Processable Files", results.FilesIterated);
            gridViewStats.Rows.Add("Processable Folders", results.DirectoriesIterated);
            gridViewStats.Rows.Add("Inaccessible Folders", results.ErrorCount);

            string ext = results.Statistics.LongestExtension;
            string value = $"{ext.Length} chars ({ext})";
            gridViewStats.Rows.Add("Longest Extension", value);

            var highest = results.Statistics.HighestQuantity;
            value = $"{highest.Count} ({highest.Extension})";
            gridViewStats.Rows.Add("Highest Quantity", value);

            gridViewStats.Rows.Add("Mean Quantity", results.Statistics.MeanQuantity);
            gridViewStats.Rows.Add("Compressed Files", results.Statistics.CompressedFileCount);
            gridViewStats.Rows.Add("No Extensions", results.Statistics.NoExtensionCount);
        }

        private void pathPicker_PickButtonClicked(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = Settings.Default.LastPath;
                dialog.ShowNewFolderButton = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                    pathPicker.SelectedPath = dialog.SelectedPath;
            }
        }

        private void pathPicker_SelectedPathChanged(object sender, EventArgs e)
        {
            buttonRunTallier.Enabled = !String.IsNullOrEmpty(pathPicker.SelectedPath);
        }

        private void buttonRunTallier_Click(object sender, EventArgs e)
        {
            CancelButtonVisible = true;
            tallier.RunAsync(pathPicker.SelectedPath, 200);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            tallier.CancelAsync();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (var dialogSaveFile = new SaveFileDialog())
            {
                dialogSaveFile.FileName = "Drive Consistency";
                dialogSaveFile.Filter = "All Files|*.*|Text File|*.txt";
                dialogSaveFile.FilterIndex = 2;

                if (dialogSaveFile.ShowDialog() == DialogResult.OK)
                {
                    var SB = new StringBuilder();
                    SB.AppendLine("[General Info]");
                    SB.AppendLine(GeneralInfoGridToString());
                    SB.AppendLine();
                    SB.AppendLine("[File Tallies]");
                    SB.AppendLine(FileTalliesToString());

                    try
                    {
                        File.WriteAllText(dialogSaveFile.FileName, SB.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    lblStatus.Text = "Exported successfully";
                }
            }
        }
    }
}
