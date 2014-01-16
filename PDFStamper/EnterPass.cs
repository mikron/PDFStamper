using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFStamper
{
    public partial class EnterPass : Form
    {
        public EnterPass()
        {
            InitializeComponent();
        }
        void SetOK()
        {
            if (this.Text.Length > 0)
            {
                this.ButtonOK.Enabled = true;
            }
            else
            {
                this.ButtonOK.Enabled = false;
            }
        }
        public void SetTitle(System.String p_Filename)
        {
            this.LabelTitle.Text = this.LabelTitle.Text.Replace("%s", p_Filename);
        }
        public System.String GetPass()
        {
            return this.PasswordMaskedTextBox.Text;
        }
        private void EnterPass_Load(object sender, EventArgs e)
        {
            this.SetOK();
        }
        private void PasswordMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SetOK();
        }
    }
}
