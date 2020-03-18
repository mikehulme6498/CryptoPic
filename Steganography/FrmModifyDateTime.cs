using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class FrmModifyDateTime : Form
    {
        string[] directoryFiles;
        public FrmModifyDateTime()
        {
            InitializeComponent();
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName.ToString();
                
            }

            FileInfo file = new FileInfo(txtFilePath.Text);
            txtData.Text = file.CreationTime.ToString();
            //file.CreationTime = DateTime.Now;
            File.SetCreationTime(txtFilePath.Text, DateTime.Now);
            File.SetLastWriteTime(txtFilePath.Text, DateTime.Now);

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string filePath = "";
            
            StringBuilder sb = new StringBuilder();

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                filePath = fbd.SelectedPath;
            }
            directoryFiles = Directory.GetFiles(filePath, "*.jpg");
            
            foreach (string files in directoryFiles)
            {
                sb.Append(files.ToString());
                sb.Append(Environment.NewLine);
            }

            txtData.Text = sb.ToString();
            lblFilesFound.Text = "Files Found : " + directoryFiles.Length.ToString();
        }

        private void FrmModifyDateTime_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            foreach (string files in directoryFiles)
            {
                File.SetCreationTime(files, dateTimePicker1.Value.Date);
                File.SetLastWriteTime(files, dateTimePicker1.Value.Date);
            }

            MessageBox.Show("Complete");
        }
    }
}
