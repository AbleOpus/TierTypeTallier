using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TierTypeTallier.Forms
{
    [DefaultEvent("PickButtonClicked")]
    public class PathPicker : Control
    {
        private readonly Button buttonClear = new Button();
        private readonly Button buttonPick = new Button();
        private readonly Label labelPath = new Label();

        #region Properties
        protected override Size DefaultSize => new Size(400, 23);

        [Description("Whether to show the clear button")]
        [DefaultValue(false), Category("Appearance")]
        public bool ShowClearButton
        {
            get { return buttonClear.Visible; }
            set { buttonClear.Visible = value; }
        }

        [Description("Occurs when the value of the SelectedPath property changes.")]
        public event EventHandler SelectedPathChanged = delegate { };
        private string selectedPath;
        [Description("The filename or directory set to display")]
        [DefaultValue(null), Category("Appearance")]
        public string SelectedPath
        {
            get { return selectedPath; }
            set
            {
                if (value == selectedPath) return;
                selectedPath = value;
                ShowPath();
                SelectedPathChanged(this, EventArgs.Empty);
            }
        }

        private string noPathCaption;
        [Description("The caption to display when there is no caption.")]
        [DefaultValue(null), Category("Appearance")]
        public string NoPathCaption
        {
            get { return noPathCaption; }
            set
            {
                noPathCaption = value;
                ShowPath();
            }
        }

        private bool shortened;
        [Description("Determines whether the path is shortened when its displayed")]
        [DefaultValue(false), Category("Appearance")]
        public bool Shortened
        {
            get { return shortened; }
            set
            {
                shortened = value;
                ShowPath();
            }
        }
        #endregion

        public PathPicker()
        {
            // labelPath
            labelPath.BorderStyle = BorderStyle.Fixed3D;
            labelPath.Dock = DockStyle.Fill;
            labelPath.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(labelPath);
            // buttonClear
            buttonClear.Dock = DockStyle.Right;
            buttonClear.Width = 75;
            buttonClear.Text = "Clear";
            buttonClear.Visible = false;
            buttonClear.Click += delegate { SelectedPath = null; };
            Controls.Add(buttonClear);
            // buttonPick
            buttonPick.Dock = DockStyle.Right;
            buttonPick.Width = 75;
            buttonPick.Text = "...";
            buttonPick.Click += delegate { OnPickButtonClicked(); };
            Controls.Add(buttonPick);
        }

        protected virtual void ShowPath()
        {
            if (String.IsNullOrWhiteSpace(SelectedPath))
            {
                labelPath.Text = NoPathCaption;
            }
            else if (shortened)
            {
                labelPath.Text = Path.GetFileName(selectedPath);
            }
            else
            {
                labelPath.Text = selectedPath;
            }
        }

        [Description("Occurs when the pick button is clicked.")]
        public event EventHandler PickButtonClicked;
        /// <summary>
        /// Raises the PickButtonClicked event
        /// </summary>
        protected virtual void OnPickButtonClicked()
        {
            PickButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
