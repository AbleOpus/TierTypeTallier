namespace TierTypeTallier.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            tallier.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gridViewTypeTally = new System.Windows.Forms.DataGridView();
            this.clmExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTally = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewStats = new System.Windows.Forms.DataGridView();
            this.clmInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRunTallier = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pathPicker = new TierTypeTallier.Forms.PathPicker();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTypeTally)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ControlLight;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            label2.Size = new System.Drawing.Size(266, 29);
            label2.TabIndex = 1;
            label2.Text = "File Type Tallies";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ControlLight;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(272, 0);
            label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            label3.Name = "label3";
            label3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            label3.Size = new System.Drawing.Size(267, 29);
            label3.TabIndex = 2;
            label3.Text = "General Info";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridViewTypeTally
            // 
            this.gridViewTypeTally.AllowUserToAddRows = false;
            this.gridViewTypeTally.AllowUserToDeleteRows = false;
            this.gridViewTypeTally.AllowUserToResizeRows = false;
            this.gridViewTypeTally.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewTypeTally.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewTypeTally.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTypeTally.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmExtension,
            this.clmTally,
            this.clmPercent});
            this.gridViewTypeTally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewTypeTally.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewTypeTally.Location = new System.Drawing.Point(0, 32);
            this.gridViewTypeTally.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.gridViewTypeTally.Name = "gridViewTypeTally";
            this.gridViewTypeTally.RowHeadersVisible = false;
            this.gridViewTypeTally.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridViewTypeTally.Size = new System.Drawing.Size(266, 376);
            this.gridViewTypeTally.TabIndex = 0;
            // 
            // clmExtension
            // 
            this.clmExtension.HeaderText = "Extension";
            this.clmExtension.Name = "clmExtension";
            // 
            // clmTally
            // 
            this.clmTally.HeaderText = "Tally";
            this.clmTally.Name = "clmTally";
            // 
            // clmPercent
            // 
            this.clmPercent.HeaderText = "Percent";
            this.clmPercent.Name = "clmPercent";
            // 
            // gridViewStats
            // 
            this.gridViewStats.AllowUserToAddRows = false;
            this.gridViewStats.AllowUserToDeleteRows = false;
            this.gridViewStats.AllowUserToResizeRows = false;
            this.gridViewStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmInfo,
            this.clmValue});
            this.gridViewStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewStats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewStats.Location = new System.Drawing.Point(272, 32);
            this.gridViewStats.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gridViewStats.Name = "gridViewStats";
            this.gridViewStats.RowHeadersVisible = false;
            this.gridViewStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridViewStats.Size = new System.Drawing.Size(267, 376);
            this.gridViewStats.TabIndex = 0;
            // 
            // clmInfo
            // 
            this.clmInfo.HeaderText = "Info";
            this.clmInfo.Name = "clmInfo";
            // 
            // clmValue
            // 
            this.clmValue.HeaderText = "Value";
            this.clmValue.Name = "clmValue";
            // 
            // buttonRunTallier
            // 
            this.buttonRunTallier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunTallier.Location = new System.Drawing.Point(451, 455);
            this.buttonRunTallier.Name = "buttonRunTallier";
            this.buttonRunTallier.Size = new System.Drawing.Size(100, 23);
            this.buttonRunTallier.TabIndex = 3;
            this.buttonRunTallier.Text = "Run";
            this.toolTip.SetToolTip(this.buttonRunTallier, "Begin the tallying process");
            this.buttonRunTallier.UseVisualStyleBackColor = true;
            this.buttonRunTallier.Click += new System.EventHandler(this.buttonRunTallier_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExport.Enabled = false;
            this.buttonExport.Location = new System.Drawing.Point(12, 455);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(100, 23);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "Export...";
            this.toolTip.SetToolTip(this.buttonExport, "Save both the type tallies and the general stats to a text file");
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(451, 455);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.toolTip.SetToolTip(this.buttonCancel, "Begin the tallying process");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(label2, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.gridViewTypeTally, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.gridViewStats, 1, 1);
            this.tableLayoutPanel.Controls.Add(label3, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(539, 408);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 484);
            this.statusStrip.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(563, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 17);
            this.lblStatus.Text = "Status: Idle";
            // 
            // pathPicker
            // 
            this.pathPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathPicker.Location = new System.Drawing.Point(12, 12);
            this.pathPicker.Name = "pathPicker";
            this.pathPicker.Size = new System.Drawing.Size(539, 23);
            this.pathPicker.TabIndex = 5;
            this.pathPicker.Text = "pathPicker1";
            this.toolTip.SetToolTip(this.pathPicker, "Pick a folder that you wish to analyze");
            this.pathPicker.SelectedPathChanged += new System.EventHandler(this.pathPicker_SelectedPathChanged);
            this.pathPicker.PickButtonClicked += new System.EventHandler(this.pathPicker_PickButtonClicked);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonRunTallier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(563, 506);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.pathPicker);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonRunTallier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(315, 230);
            this.Name = "MainForm";
            this.Text = "Tier Type Tallier";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTypeTally)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewTypeTally;
        private System.Windows.Forms.DataGridView gridViewStats;
        private System.Windows.Forms.Button buttonRunTallier;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ToolTip toolTip;
        private PathPicker pathPicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTally;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button buttonCancel;
    }
}

