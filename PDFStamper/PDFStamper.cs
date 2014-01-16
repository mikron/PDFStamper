using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PDFStamper
{
    public partial class PDFStamper : Form
    {
        public PDFStamper()
        {
            InitializeComponent();
            this.m_RootDir = System.String.Empty;
            this.m_WorkInfo = new WorkInfo();
            this.m_WorkCompleted = false;
        }
        void SetStamp()
        {
            if (this.DataGridViewFiles.RowCount > 0) {
                this.Stamp.Enabled = true;
            } else {
                this.Stamp.Enabled = false;
            } 
        }
        private bool IsPasswordProtected(System.String pdfFullname)
        {
            try
            {
                PdfReader pdfReader = new PdfReader(pdfFullname);
                pdfReader.Close();
                return false;
            }
            catch (BadPasswordException)
            {
                return true;
            }
        }
        private System.String GetPass(System.String p_FilePath, System.String p_FileName)
        {
            try
            {
                EnterPass l_EntrPass = new EnterPass();
                l_EntrPass.SetTitle(p_FileName);
                System.Windows.Forms.DialogResult ld_EntrPassResult = l_EntrPass.ShowDialog();
                if (ld_EntrPassResult == System.Windows.Forms.DialogResult.OK)
                {
                    byte[] l_Password = System.Text.ASCIIEncoding.ASCII.GetBytes(l_EntrPass.GetPass());
                    try
                    {
                        PdfReader pdfReader = new PdfReader(p_FilePath, l_Password);
                        pdfReader.Close();
                        return l_EntrPass.GetPass();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "PDF-Stamper", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return GetPass(p_FilePath, p_FileName);
                    }
                }
                return System.String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PDF-Stamper", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return System.String.Empty;
            }
        }
        private void InsertFileGrid(System.String p_FilePath)
        {
            try
            {
                if (p_FilePath.Substring(p_FilePath.LastIndexOf(".") + 1).ToUpper() == "PDF")
                {
                    this.DataGridViewFiles.Rows.Add(1);
                    System.Int32 li_index = this.DataGridViewFiles.RowCount;
                    System.Windows.Forms.DataGridViewCellCollection lc_Cells = this.DataGridViewFiles.Rows[li_index - 1].Cells;
                    lc_Cells[0].Value = li_index;
                    lc_Cells[1].Value = p_FilePath.Substring(p_FilePath.LastIndexOf("\\") + 1);
                    lc_Cells[2].Value = p_FilePath.Substring(0, p_FilePath.LastIndexOf("\\"));
                    lc_Cells[3].Value = p_FilePath;
                    if (this.IsPasswordProtected(p_FilePath))
                    {
                        lc_Cells[4].Value = this.GetPass(p_FilePath, lc_Cells[1].Value.ToString());
                    }
                    else
                    {
                        lc_Cells[4].Value = System.String.Empty;
                    }
                 }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "PDF-Stamper", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void FillFileGrid()
        {
            string[] fullfilesPath = System.IO.Directory.GetFiles(this.m_RootDir, "*.*", System.IO.SearchOption.AllDirectories);
            this.DataGridViewFiles.Rows.Clear();
            Action<System.String> action = new Action<System.String>(InsertFileGrid);
            Array.ForEach(fullfilesPath, action);
        }
        private void ListBoxDefSettings()
        {
            this.ListBoxFileStep.Items.Clear();
            this.ListBoxFileStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }
        private void SetFileInfo()
        {
            PdfReader pdf_Reader = null;
            try {
                if (this.m_WorkInfo.m_FilesInfo.Count > 0) {
                    this.m_WorkInfo.m_FilesInfo.Clear();
                    this.m_WorkInfo.m_TotalWork = 0;
                }
                for (int i = 0; i < this.DataGridViewFiles.Rows.Count; ++i)
                {
                    System.String ls_FullFile = this.DataGridViewFiles.Rows[i].Cells[3].Value.ToString();
                    System.String ls_Pass = this.DataGridViewFiles.Rows[i].Cells[4].Value.ToString();
                    if (ls_Pass != System.String.Empty)
                    {
                        byte[] lb_Password = System.Text.ASCIIEncoding.ASCII.GetBytes(ls_Pass);
                        pdf_Reader = new PdfReader(ls_FullFile, lb_Password);
                    }
                    else
                    {
                        pdf_Reader = new PdfReader(ls_FullFile);
                    }                    
                    System.Int32 PageCount = pdf_Reader.NumberOfPages;
                    this.m_WorkInfo.m_FilesInfo.Add(ls_FullFile, PageCount);
                    this.m_WorkInfo.m_TotalWork = this.m_WorkInfo.m_TotalWork + PageCount;
                    pdf_Reader.Close();
                }
            } catch (System.Exception ex) {
                if (pdf_Reader != null) {
                    pdf_Reader.Close();
                }
                MessageBox.Show(ex.Message, "PDF-Stamper", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void SetProgressBar(System.Int32 p_Min, System.Int32 p_Max, System.Int32 p_Val)
        {
            this.StampProgressBar.Minimum = p_Min;
            this.StampProgressBar.Maximum = p_Max;
            this.StampProgressBar.Value = p_Val;
        }
        private void DelFiles()
        {
            if (this.m_WorkCompleted)
            {
                for (int i = 0; i < this.DataGridViewFiles.Rows.Count; ++i)
                {
                    System.String ls_FullFile = this.DataGridViewFiles.Rows[i].Cells[3].Value.ToString();
                    System.String ls_NewFullFile = this.DataGridViewFiles.Rows[i].Cells[5].Value.ToString(); 
                    System.IO.FileInfo l_DeFile = new System.IO.FileInfo(ls_FullFile);
                    l_DeFile.Delete();

                    System.String ls_Pass = this.DataGridViewFiles.Rows[i].Cells[4].Value.ToString();
                    if (ls_Pass != System.String.Empty) 
                    {
                        System.String ls_NewPassFullFile = this.DataGridViewFiles.Rows[i].Cells[6].Value.ToString();
                        using (Stream input = new FileStream(ls_NewFullFile, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            using (Stream output = new FileStream(ls_NewPassFullFile, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                byte[] lb_Password = System.Text.ASCIIEncoding.ASCII.GetBytes(ls_Pass);
                                PdfReader pdf_Reader = new PdfReader(input, lb_Password);
                                PdfEncryptor.Encrypt(pdf_Reader, output, true, ls_Pass, ls_Pass, PdfWriter.ALLOW_SCREENREADERS);
                                l_DeFile = new System.IO.FileInfo(ls_NewFullFile);
                                l_DeFile.Delete();
                                System.IO.File.Move(ls_NewPassFullFile, ls_FullFile);
                            }
                        }
                    }
                    else
                    {                                                                     
                        System.IO.File.Move(ls_NewFullFile, ls_FullFile);
                    }
                }
            }
        }
        private void PDFStamper_Load(object sender, EventArgs e)
        {
            this.SetStamp();
        }
        private void Stamp_Click(object sender, EventArgs e)
        {
            this.m_WorkCompleted = false;
            this.Stamp.Enabled = false;
            this.ListBoxFileStep.Items.Add("Work appraisal ...");
            this.Update();
            this.ListBoxDefSettings();
            this.SetFileInfo();
            this.SetProgressBar(0, this.m_WorkInfo.m_TotalWork, 0);
            this.BackgroundWorkerStamp.RunWorkerAsync(this.m_WorkInfo);            
        }
        private void ButtonSelectPath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult ld_Result = this.DialogSelPath.ShowDialog();
            if (ld_Result == System.Windows.Forms.DialogResult.OK) {
                this.TextBoxSelectPath.Text = this.DialogSelPath.SelectedPath;
                this.m_RootDir = this.DialogSelPath.SelectedPath;
                this.FillFileGrid();
            } else {
                this.TextBoxSelectPath.Clear();
                this.m_RootDir = System.String.Empty;
            }
            this.SetStamp();
        }
        private void BackgroundWorkerStamp_DoWork(object sender, DoWorkEventArgs e)
        {
            // Cannot referenced progressBar and listBox on this method!
            try {
                WorkInfo lt_WorkInfo = (WorkInfo)e.Argument;
                WorkStep lt_WorkStep = new WorkStep();
                System.Int32 li_Start = 0;
                System.Int32 li_End = 0;
                byte[] password = System.Text.ASCIIEncoding.ASCII.GetBytes("elance");
                
                for (int i = 0; i < this.DataGridViewFiles.Rows.Count; ++i)
                {
                    System.String ls_FullFile = this.DataGridViewFiles.Rows[i].Cells[3].Value.ToString();
                    System.Int32 li_PageCout = lt_WorkInfo.m_FilesInfo[ls_FullFile];

                    lt_WorkStep.m_StateMessage = ls_FullFile;
                    lt_WorkStep.m_ShowMessage = true;

                    li_Start = li_End + 1;
                    li_End = li_End + li_PageCout;
                    System.Int32 li_Pagenum = 1;
                    
                    System.String ls_NewFile1 = ls_FullFile.Substring(0, ls_FullFile.LastIndexOf(".")) + "_" + ".pdf";
                    System.String ls_NewFile2 = ls_FullFile.Substring(0, ls_FullFile.LastIndexOf(".")) + "__" + ".pdf";
                    PdfReader Pdf_Reader = new PdfReader(ls_FullFile, password);
                    FileStream File_Stream = new FileStream(ls_NewFile1, FileMode.Create, FileAccess.Write, FileShare.None);
                    using (PdfStamper Pdf_Stamper = new PdfStamper(Pdf_Reader, File_Stream))
                    {
                        BaseFont l_Font = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.WINANSI, BaseFont.EMBEDDED);
                        for (int p = li_Start; p <= li_End; ++p)
                        {
                            if (this.BackgroundWorkerStamp.CancellationPending)
                            {
                                e.Cancel = true;
                                return;
                            }
                            else
                            {
                                for (System.Int32 j = 0; j <= 100000; ++j);

                                iTextSharp.text.Rectangle l_Rect = Pdf_Reader.GetPageSize(li_Pagenum);
                                System.String ls_StampText = "(" + this.DataGridViewFiles.Rows[i].Cells[1].Value.ToString();
                                ls_StampText = ls_StampText.Substring(0, ls_StampText.LastIndexOf(".")) + "-Page " + li_Pagenum.ToString() + ")";
                                PdfContentByte l_Content = Pdf_Stamper.GetOverContent(li_Pagenum++);
                                l_Content.BeginText();
                                l_Content.SetTextMatrix(10, l_Rect.Height - 15);    
                                l_Content.SetFontAndSize(l_Font, 10);
                                l_Content.SetColorFill(BaseColor.RED);
                                l_Content.ShowText(ls_StampText);
                                l_Content.EndText();

                                DataGridViewFiles.Rows[i].Cells[5].Value = ls_NewFile1;
                                DataGridViewFiles.Rows[i].Cells[6].Value = ls_NewFile2;

                                lt_WorkStep.m_ProgressPercentage = p;
                                this.BackgroundWorkerStamp.ReportProgress(0, lt_WorkStep);                                
                            }
                        }
                    }
                    Pdf_Reader.Close();
                    File_Stream.Close();
                }
            } catch (System.Exception ex) {
                e.Cancel = true;
                System.Windows.Forms.MessageBox.Show(ex.Message, "PDF-Stamper", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        private void BackgroundWorkerStamp_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WorkStep lt_WorkStep = (WorkStep)e.UserState;
            this.StampProgressBar.Value = lt_WorkStep.m_ProgressPercentage;
            if (lt_WorkStep.m_ShowMessage)
            {
                this.ListBoxFileStep.Items.Add(lt_WorkStep.m_StateMessage);
                lt_WorkStep.m_ShowMessage = false;
            }
            this.Update();
        }
        private void BackgroundWorkerStamp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.ListBoxFileStep.Items.Clear();
            this.ListBoxFileStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            if (e.Error != null || e.Cancelled) {
                this.ListBoxFileStep.Items.Add("Process is failed");
            } else {
                this.ListBoxFileStep.Items.Add("Process is successfully finished!");
            }
            this.StampProgressBar.Value = 0;
            this.m_WorkCompleted = true;
            this.Update();
            this.DelFiles();
        }
        private void TextBoxSelectPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TextBoxSelectPath.Text.Length > 0)
                {
                    this.TextBoxSelectPath.TextChanged -= new System.EventHandler(this.TextBoxSelectPath_TextChanged);
                    this.TextBoxSelectPath.Text = this.TextBoxSelectPath.Text.Replace(@"\", @"\\");
                    this.m_RootDir = this.TextBoxSelectPath.Text;
                    this.FillFileGrid();
                    this.SetStamp();
                    this.TextBoxSelectPath.TextChanged += new System.EventHandler(this.TextBoxSelectPath_TextChanged);
                }
            }
            catch (System.Exception ex)
            {
                this.TextBoxSelectPath.TextChanged += new System.EventHandler(this.TextBoxSelectPath_TextChanged);
                System.Windows.Forms.MessageBox.Show(ex.Message, "PDF-Stamper", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
