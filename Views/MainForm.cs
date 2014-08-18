using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TierTypeTallier.FileTallying;
using TierTypeTallier.Properties;

namespace TierTypeTallier.Views
{
    public partial class MainForm : Form
    {
        private readonly FileTallier _tallier = new FileTallier();

        /// <summary>
        /// Gets or sets whether the cancel button is visible
        /// </summary>
        private bool CancelButtonVisible
        {
            get { return btnCancel.Visible; }
            set
            {
                btnCancel.Visible = value;
                btnRunTallier.Visible = !value;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            _tallier.ProgressReport += (s, files) =>
            {
                const string FORMAT = "Busy ({0} files iterated)";
                lblStatus.Text = String.Format(FORMAT, files);
            };

            _tallier.TallierCompleted += (sender, results) =>
            {
                lblStatus.Text = "Idle";
                PopulateTallyGrid(results);
                PopulateAdditionalInfoGrid(results);
                CancelButtonVisible = false;
                btnExport.Enabled = (dgvStats.Rows.Count > 0 || dgvTypeTally.Rows.Count > 0);
                lblStatus.Text = results.Cancelled ? "Tallier cancelled" : "Tallier completed successfully";
            };

            // If the last path is empty, then set it to current drive
            if (String.IsNullOrEmpty(Settings.Default.LastPath))
                Settings.Default.LastPath = Path.GetPathRoot(Application.StartupPath);
            // Binds last path to its corresponding property
            pathPicker.DataBindings.Add("SelectedPath", Settings.Default, "LastPath");
        }

        /// <summary>
        /// Gets the general info as a string
        /// </summary>
        private string GeneralInfoGridToString()
        {
            var SB = new StringBuilder();

            foreach (DataGridViewRow row in dgvStats.Rows)
                SB.AppendLine(String.Format("{0}: {1}", row.Cells[0].Value, row.Cells[1].Value));

            return SB.ToString().TrimEnd();
        }

        /// <summary>
        /// Gets the file tallies as a string
        /// </summary>
        private string FileTalliesToString()
        {
            var SB = new StringBuilder();

            foreach (DataGridViewRow row in dgvTypeTally.Rows)
            {
                SB.AppendLine(String.Format("{0}% ({1}) of {2}", row.Cells[2].Value,
                    row.Cells[1].Value, row.Cells[0].Value));
            }

            return SB.ToString().TrimEnd();
        }

        /// <summary>
        /// Loads the file-type tally data grid view with data
        /// </summary>
        private void PopulateTallyGrid(FileTallierResults results)
        {
            dgvTypeTally.Rows.Clear();
            double total = 0;

            foreach (var tally in results.Tallies)
            {
                double percent = results.Statistics.GetPercent(tally);
                total += percent;
                string strPercent = Math.Round(percent, 3) + "%";
                dgvTypeTally.Rows.Add(tally.Extension, tally.Count, strPercent);
            }
        }

        /// <summary>
        /// Loads the general info data grid view with data
        /// </summary>
        private void PopulateAdditionalInfoGrid(FileTallierResults results)
        {
            dgvStats.Rows.Clear();
            dgvStats.Rows.Add("Proccessable Files", results.FilesIterated);
            dgvStats.Rows.Add("Proccessable Folders", results.DirectoriesIterated);
            dgvStats.Rows.Add("Inaccessible Folders", results.ErrorCount);

            const string FORMAT = "{0} chars ({1})";
            string ext = results.Statistics.LongestExtension;
            string value = String.Format(FORMAT, ext.Length, ext);
            dgvStats.Rows.Add("Longest Extension", value);

            var highest = results.Statistics.HighestQuantity;
            value = String.Format("{0} ({1})", highest.Count, highest.Extension);
            dgvStats.Rows.Add("Highest Quantity", value);

            dgvStats.Rows.Add("Mean Quantity", results.Statistics.MeanQuantity);
            dgvStats.Rows.Add("Compressed Files", results.Statistics.CompressedFileCount);
            dgvStats.Rows.Add("No Extensions", results.Statistics.NoExtensionCount);
        }

        private void pathPicker_PickButtonClicked(object sender, EventArgs e)
        {
            using (var dlgFolderBrowser = new FolderBrowserDialog())
            {
                dlgFolderBrowser.SelectedPath = Settings.Default.LastPath;
                dlgFolderBrowser.ShowNewFolderButton = false;

                if (dlgFolderBrowser.ShowDialog() == DialogResult.OK)
                    pathPicker.SelectedPath = dlgFolderBrowser.SelectedPath;
            }
        }

        private void pathPicker_SelectedPathChanged(object sender, EventArgs e)
        {
            btnRunTallier.Enabled = !String.IsNullOrEmpty(pathPicker.SelectedPath);
        }

        private void btnRunTallier_Click(object sender, EventArgs e)
        {
            CancelButtonVisible = true;
            //string testDir = Application.StartupPath + @"\Test Dir";
            // Report progress every 200 files otherwise an update event (ProgressReport)
            // will fire faster than it needs to
            _tallier.RunAsync(pathPicker.SelectedPath, 200);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _tallier.CancelAsync();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var dlgSaveFile = new SaveFileDialog())
            {
                dlgSaveFile.FileName = "Drive Consistency";
                dlgSaveFile.Filter = "All Files|*.*|Text File|*.txt";
                dlgSaveFile.FilterIndex = 2;

                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    var SB = new StringBuilder();
                    SB.AppendLine("[General Info]");
                    SB.AppendLine(GeneralInfoGridToString());
                    SB.AppendLine();
                    SB.AppendLine("[File Tallies]");
                    SB.AppendLine(FileTalliesToString());

                    try
                    {
                        File.WriteAllText(dlgSaveFile.FileName, SB.ToString());
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
