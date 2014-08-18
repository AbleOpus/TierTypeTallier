namespace TierTypeTallier.Views
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
            _tallier.Dispose();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvTypeTally = new System.Windows.Forms.DataGridView();
            this.clmExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTally = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.clmInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRunTallier = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pathPicker = new TierTypeTallier.Views.PathPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeTally)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTypeTally
            // 
            this.dgvTypeTally.AllowUserToAddRows = false;
            this.dgvTypeTally.AllowUserToDeleteRows = false;
            this.dgvTypeTally.AllowUserToResizeRows = false;
            this.dgvTypeTally.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTypeTally.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTypeTally.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeTally.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmExtension,
            this.clmTally,
            this.clmPercent});
            this.dgvTypeTally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTypeTally.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTypeTally.Location = new System.Drawing.Point(0, 35);
            this.dgvTypeTally.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dgvTypeTally.Name = "dgvTypeTally";
            this.dgvTypeTally.RowHeadersVisible = false;
            this.dgvTypeTally.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTypeTally.Size = new System.Drawing.Size(266, 373);
            this.dgvTypeTally.TabIndex = 0;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Type Tallies";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStats
            // 
            this.dgvStats.AllowUserToAddRows = false;
            this.dgvStats.AllowUserToDeleteRows = false;
            this.dgvStats.AllowUserToResizeRows = false;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmInfo,
            this.clmValue});
            this.dgvStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStats.Location = new System.Drawing.Point(272, 35);
            this.dgvStats.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.RowHeadersVisible = false;
            this.dgvStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStats.Size = new System.Drawing.Size(267, 373);
            this.dgvStats.TabIndex = 0;
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "General Info";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRunTallier
            // 
            this.btnRunTallier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunTallier.Location = new System.Drawing.Point(451, 455);
            this.btnRunTallier.Name = "btnRunTallier";
            this.btnRunTallier.Size = new System.Drawing.Size(100, 23);
            this.btnRunTallier.TabIndex = 3;
            this.btnRunTallier.Text = "Run Tallier";
            this.toolTip.SetToolTip(this.btnRunTallier, "Begin the tallying process");
            this.btnRunTallier.UseVisualStyleBackColor = true;
            this.btnRunTallier.Click += new System.EventHandler(this.btnRunTallier_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(12, 455);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export...";
            this.toolTip.SetToolTip(this.btnExport, "Save both the type tallies and the general stats to a text file");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(451, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.toolTip.SetToolTip(this.btnCancel, "Begin the tallying process");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dgvTypeTally, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dgvStats, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(539, 408);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(563, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
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
            this.AcceptButton = this.btnRunTallier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(563, 506);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.pathPicker);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnRunTallier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(315, 230);
            this.Name = "MainForm";
            this.Text = "Tier Type Tallier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeTally)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTypeTally;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRunTallier;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ToolTip toolTip;
        private PathPicker pathPicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTally;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnCancel;
    }
}

