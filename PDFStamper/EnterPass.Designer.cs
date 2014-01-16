namespace PDFStamper
{
    partial class EnterPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterPass));
            this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelPass = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.PanelPass = new System.Windows.Forms.Panel();
            this.PasswordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TableLayoutPanelMain.SuspendLayout();
            this.TableLayoutPanelPass.SuspendLayout();
            this.PanelPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.ColumnCount = 1;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelMain.Controls.Add(this.TableLayoutPanelPass, 0, 1);
            this.TableLayoutPanelMain.Controls.Add(this.PanelPass, 0, 0);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 2;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.54386F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.45614F));
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(430, 114);
            this.TableLayoutPanelMain.TabIndex = 0;
            // 
            // TableLayoutPanelPass
            // 
            this.TableLayoutPanelPass.ColumnCount = 3;
            this.TableLayoutPanelPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelPass.Controls.Add(this.ButtonOK, 1, 0);
            this.TableLayoutPanelPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelPass.Location = new System.Drawing.Point(3, 80);
            this.TableLayoutPanelPass.Name = "TableLayoutPanelPass";
            this.TableLayoutPanelPass.RowCount = 1;
            this.TableLayoutPanelPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelPass.Size = new System.Drawing.Size(424, 31);
            this.TableLayoutPanelPass.TabIndex = 0;
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Location = new System.Drawing.Point(172, 3);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 0;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // PanelPass
            // 
            this.PanelPass.Controls.Add(this.PasswordMaskedTextBox);
            this.PanelPass.Controls.Add(this.LabelTitle);
            this.PanelPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPass.Location = new System.Drawing.Point(3, 3);
            this.PanelPass.Name = "PanelPass";
            this.PanelPass.Size = new System.Drawing.Size(424, 71);
            this.PanelPass.TabIndex = 1;
            // 
            // PasswordMaskedTextBox
            // 
            this.PasswordMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PasswordMaskedTextBox.Location = new System.Drawing.Point(12, 40);
            this.PasswordMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            this.PasswordMaskedTextBox.Size = new System.Drawing.Size(249, 20);
            this.PasswordMaskedTextBox.TabIndex = 7;
            this.PasswordMaskedTextBox.UseSystemPasswordChar = true;
            this.PasswordMaskedTextBox.TextChanged += new System.EventHandler(this.PasswordMaskedTextBox_TextChanged);
            // 
            // LabelTitle
            // 
            this.LabelTitle.Location = new System.Drawing.Point(9, 13);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(252, 17);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Set %s file password";
            // 
            // EnterPass
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 114);
            this.Controls.Add(this.TableLayoutPanelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter password";
            this.Load += new System.EventHandler(this.EnterPass_Load);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.TableLayoutPanelPass.ResumeLayout(false);
            this.PanelPass.ResumeLayout(false);
            this.PanelPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelPass;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Panel PanelPass;
        private System.Windows.Forms.MaskedTextBox PasswordMaskedTextBox;
        private System.Windows.Forms.Label LabelTitle;
    }
}