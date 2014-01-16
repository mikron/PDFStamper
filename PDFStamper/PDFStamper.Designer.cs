namespace PDFStamper
{
    partial class PDFStamper
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFStamper));
            this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBoxFiles = new System.Windows.Forms.GroupBox();
            this.DataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.Rnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenameFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenamePassFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelSelectPath = new System.Windows.Forms.Panel();
            this.ButtonSelectPath = new System.Windows.Forms.Button();
            this.TextBoxSelectPath = new System.Windows.Forms.TextBox();
            this.TableLayoutPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.Stamp = new System.Windows.Forms.Button();
            this.PanelStampProcess = new System.Windows.Forms.Panel();
            this.StampProgressBar = new System.Windows.Forms.ProgressBar();
            this.GroupBoxFileStep = new System.Windows.Forms.GroupBox();
            this.ListBoxFileStep = new System.Windows.Forms.ListBox();
            this.DialogSelPath = new System.Windows.Forms.FolderBrowserDialog();
            this.BackgroundWorkerStamp = new System.ComponentModel.BackgroundWorker();
            this.TableLayoutPanelMain.SuspendLayout();
            this.GroupBoxFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFiles)).BeginInit();
            this.PanelSelectPath.SuspendLayout();
            this.TableLayoutPanelButton.SuspendLayout();
            this.PanelStampProcess.SuspendLayout();
            this.GroupBoxFileStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.ColumnCount = 1;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMain.Controls.Add(this.GroupBoxFiles, 0, 2);
            this.TableLayoutPanelMain.Controls.Add(this.PanelSelectPath, 0, 1);
            this.TableLayoutPanelMain.Controls.Add(this.TableLayoutPanelButton, 0, 5);
            this.TableLayoutPanelMain.Controls.Add(this.PanelStampProcess, 0, 4);
            this.TableLayoutPanelMain.Controls.Add(this.GroupBoxFileStep, 0, 3);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 6;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.077922F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.50649F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.67533F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.155844F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.87013F));
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(694, 385);
            this.TableLayoutPanelMain.TabIndex = 0;
            // 
            // GroupBoxFiles
            // 
            this.GroupBoxFiles.Controls.Add(this.DataGridViewFiles);
            this.GroupBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxFiles.Location = new System.Drawing.Point(3, 63);
            this.GroupBoxFiles.Name = "GroupBoxFiles";
            this.GroupBoxFiles.Size = new System.Drawing.Size(688, 169);
            this.GroupBoxFiles.TabIndex = 2;
            this.GroupBoxFiles.TabStop = false;
            this.GroupBoxFiles.Text = "Folder files";
            // 
            // DataGridViewFiles
            // 
            this.DataGridViewFiles.AccessibleDescription = "";
            this.DataGridViewFiles.AccessibleName = "";
            this.DataGridViewFiles.AllowUserToAddRows = false;
            this.DataGridViewFiles.AllowUserToDeleteRows = false;
            this.DataGridViewFiles.AllowUserToOrderColumns = true;
            this.DataGridViewFiles.AllowUserToResizeRows = false;
            this.DataGridViewFiles.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rnum,
            this.Filename,
            this.Directory,
            this.FullFile,
            this.Pass,
            this.RenameFile,
            this.RenamePassFile});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewFiles.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridViewFiles.Location = new System.Drawing.Point(3, 18);
            this.DataGridViewFiles.MultiSelect = false;
            this.DataGridViewFiles.Name = "DataGridViewFiles";
            this.DataGridViewFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewFiles.RowHeadersWidth = 23;
            this.DataGridViewFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewFiles.Size = new System.Drawing.Size(682, 148);
            this.DataGridViewFiles.TabIndex = 1;
            // 
            // Rnum
            // 
            this.Rnum.HeaderText = "N";
            this.Rnum.Name = "Rnum";
            this.Rnum.ReadOnly = true;
            this.Rnum.ToolTipText = "N";
            this.Rnum.Width = 50;
            // 
            // Filename
            // 
            this.Filename.HeaderText = "File name";
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            this.Filename.ToolTipText = "File name";
            this.Filename.Width = 250;
            // 
            // Directory
            // 
            this.Directory.HeaderText = "Directory";
            this.Directory.Name = "Directory";
            this.Directory.ReadOnly = true;
            this.Directory.ToolTipText = "Directory";
            this.Directory.Width = 360;
            // 
            // FullFile
            // 
            this.FullFile.HeaderText = "FullFile";
            this.FullFile.Name = "FullFile";
            this.FullFile.ReadOnly = true;
            this.FullFile.ToolTipText = "FullFile";
            this.FullFile.Visible = false;
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Pass";
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            this.Pass.ToolTipText = "Pass";
            this.Pass.Visible = false;
            // 
            // RenameFile
            // 
            this.RenameFile.HeaderText = "RenameFile";
            this.RenameFile.Name = "RenameFile";
            this.RenameFile.ReadOnly = true;
            this.RenameFile.ToolTipText = "RenameFile";
            this.RenameFile.Visible = false;
            // 
            // RenamePassFile
            // 
            this.RenamePassFile.HeaderText = "RenamePassFile";
            this.RenamePassFile.Name = "RenamePassFile";
            this.RenamePassFile.ReadOnly = true;
            this.RenamePassFile.ToolTipText = "RenamePassFile";
            this.RenamePassFile.Visible = false;
            // 
            // PanelSelectPath
            // 
            this.PanelSelectPath.Controls.Add(this.ButtonSelectPath);
            this.PanelSelectPath.Controls.Add(this.TextBoxSelectPath);
            this.PanelSelectPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSelectPath.Location = new System.Drawing.Point(3, 11);
            this.PanelSelectPath.Name = "PanelSelectPath";
            this.PanelSelectPath.Size = new System.Drawing.Size(688, 46);
            this.PanelSelectPath.TabIndex = 3;
            // 
            // ButtonSelectPath
            // 
            this.ButtonSelectPath.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSelectPath.Image")));
            this.ButtonSelectPath.Location = new System.Drawing.Point(3, 12);
            this.ButtonSelectPath.Name = "ButtonSelectPath";
            this.ButtonSelectPath.Size = new System.Drawing.Size(26, 24);
            this.ButtonSelectPath.TabIndex = 7;
            this.ButtonSelectPath.UseVisualStyleBackColor = true;
            this.ButtonSelectPath.Click += new System.EventHandler(this.ButtonSelectPath_Click);
            // 
            // TextBoxSelectPath
            // 
            this.TextBoxSelectPath.Location = new System.Drawing.Point(35, 14);
            this.TextBoxSelectPath.Name = "TextBoxSelectPath";
            this.TextBoxSelectPath.Size = new System.Drawing.Size(474, 22);
            this.TextBoxSelectPath.TabIndex = 0;
            this.TextBoxSelectPath.TextChanged += new System.EventHandler(this.TextBoxSelectPath_TextChanged);
            // 
            // TableLayoutPanelButton
            // 
            this.TableLayoutPanelButton.ColumnCount = 3;
            this.TableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.TableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.TableLayoutPanelButton.Controls.Add(this.Stamp, 1, 0);
            this.TableLayoutPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelButton.Location = new System.Drawing.Point(3, 349);
            this.TableLayoutPanelButton.Name = "TableLayoutPanelButton";
            this.TableLayoutPanelButton.RowCount = 1;
            this.TableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelButton.Size = new System.Drawing.Size(688, 33);
            this.TableLayoutPanelButton.TabIndex = 0;
            // 
            // Stamp
            // 
            this.Stamp.Location = new System.Drawing.Point(308, 3);
            this.Stamp.Name = "Stamp";
            this.Stamp.Size = new System.Drawing.Size(70, 25);
            this.Stamp.TabIndex = 0;
            this.Stamp.Text = "Stamp";
            this.Stamp.UseVisualStyleBackColor = true;
            this.Stamp.Click += new System.EventHandler(this.Stamp_Click);
            // 
            // PanelStampProcess
            // 
            this.PanelStampProcess.Controls.Add(this.StampProgressBar);
            this.PanelStampProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelStampProcess.Location = new System.Drawing.Point(3, 333);
            this.PanelStampProcess.Name = "PanelStampProcess";
            this.PanelStampProcess.Size = new System.Drawing.Size(688, 10);
            this.PanelStampProcess.TabIndex = 0;
            // 
            // StampProgressBar
            // 
            this.StampProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StampProgressBar.Location = new System.Drawing.Point(0, 0);
            this.StampProgressBar.Name = "StampProgressBar";
            this.StampProgressBar.Size = new System.Drawing.Size(688, 10);
            this.StampProgressBar.TabIndex = 1;
            // 
            // GroupBoxFileStep
            // 
            this.GroupBoxFileStep.Controls.Add(this.ListBoxFileStep);
            this.GroupBoxFileStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxFileStep.Location = new System.Drawing.Point(3, 238);
            this.GroupBoxFileStep.Name = "GroupBoxFileStep";
            this.GroupBoxFileStep.Size = new System.Drawing.Size(688, 89);
            this.GroupBoxFileStep.TabIndex = 4;
            this.GroupBoxFileStep.TabStop = false;
            this.GroupBoxFileStep.Text = "File step";
            // 
            // ListBoxFileStep
            // 
            this.ListBoxFileStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxFileStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxFileStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxFileStep.FormattingEnabled = true;
            this.ListBoxFileStep.ItemHeight = 18;
            this.ListBoxFileStep.Location = new System.Drawing.Point(3, 18);
            this.ListBoxFileStep.Name = "ListBoxFileStep";
            this.ListBoxFileStep.ScrollAlwaysVisible = true;
            this.ListBoxFileStep.Size = new System.Drawing.Size(682, 68);
            this.ListBoxFileStep.TabIndex = 0;
            // 
            // DialogSelPath
            // 
            this.DialogSelPath.Tag = "";
            // 
            // BackgroundWorkerStamp
            // 
            this.BackgroundWorkerStamp.WorkerReportsProgress = true;
            this.BackgroundWorkerStamp.WorkerSupportsCancellation = true;
            this.BackgroundWorkerStamp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerStamp_DoWork);
            this.BackgroundWorkerStamp.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerStamp_ProgressChanged);
            this.BackgroundWorkerStamp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerStamp_RunWorkerCompleted);
            // 
            // PDFStamper
            // 
            this.AcceptButton = this.Stamp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 385);
            this.Controls.Add(this.TableLayoutPanelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PDFStamper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF-Stamper";
            this.Load += new System.EventHandler(this.PDFStamper_Load);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.GroupBoxFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFiles)).EndInit();
            this.PanelSelectPath.ResumeLayout(false);
            this.PanelSelectPath.PerformLayout();
            this.TableLayoutPanelButton.ResumeLayout(false);
            this.PanelStampProcess.ResumeLayout(false);
            this.GroupBoxFileStep.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.String m_RootDir;
        private WorkInfo m_WorkInfo;
        private System.Boolean m_WorkCompleted;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelButton;
        private System.Windows.Forms.Button Stamp;
        private System.Windows.Forms.GroupBox GroupBoxFiles;
        private System.Windows.Forms.Panel PanelSelectPath;
        private System.Windows.Forms.TextBox TextBoxSelectPath;
        private System.Windows.Forms.Panel PanelStampProcess;
        private System.Windows.Forms.ProgressBar StampProgressBar;
        private System.Windows.Forms.GroupBox GroupBoxFileStep;
        private System.Windows.Forms.ListBox ListBoxFileStep;
        private System.Windows.Forms.Button ButtonSelectPath;
        private System.Windows.Forms.FolderBrowserDialog DialogSelPath;
        private System.Windows.Forms.DataGridView DataGridViewFiles;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn RenameFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn RenamePassFile;
    }
}

