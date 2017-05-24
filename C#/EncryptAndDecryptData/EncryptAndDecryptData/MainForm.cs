using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace EncryptAndDecryptData
{
    public partial class MainForm : Form
    {
        private Boolean isFileSelect = true;
        Classes.LogicMainForm logic = new Classes.LogicMainForm();
        private Classes.EncryptAndDecryptData enAndDeData;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //enAndDeData = new EncryptAndDecryptData.Classes.EncryptAndDecryptData(txtKeyValue.Text);
        }

        //./File Data Group-------------------------------START/.//
        private void btnFileInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            DialogResult result = openFileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileInput.Text = openFileDlg.FileName;
            }
        }

        private void btnFileOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            DialogResult result = saveFileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileOutput.Text = saveFileDlg.FileName;
            }

        }
        //./File Data Group----------------------------------END/.//
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        //./Folder Data Group-------------------------------START/.//
        private void btnFolderInput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFolderInput.Text = folderDlg.SelectedPath;
                isFileSelect = false;
            }
        }

        private void btnFolderOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFolderOutput.Text = folderDlg.SelectedPath + "/";
            }
        }
        //./Folder Data Group---------------------------------END/.//
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        //./Key Data Group---------------------------------START/.//
        private void btnDefaultKey_Click(object sender, EventArgs e)
        {
            txtKeyValue.Text = Common.Constants.AFTECH_KEY_LANGUAGE;
        }

        private void btnExportKey_Click(object sender, EventArgs e)
        {

        }

        private void btnImportKey_Click(object sender, EventArgs e)
        {

        }
        //./Key Data Group----------------------------------END/.//
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void btnDecryptData_Click(object sender, EventArgs e)
        {
            enableButton(false);
            if (isFileSelect)
            {
                if (String.IsNullOrEmpty(txtFileInput.Text))
                {
                    MessageBox.Show("Please input input file!");
                    return;
                }

                if (String.IsNullOrEmpty(txtFileOutput.Text))
                {
                    txtFileOutput.Text = logic.AutoCreateOutputFolder(txtFileInput.Text, @"_decrypt\", "jpg");
                }

                if (String.IsNullOrEmpty(txtKeyValue.Text))
                {
                    MessageBox.Show("Please input key!");
                    return;
                }

                enAndDeData = new EncryptAndDecryptData.Classes.EncryptAndDecryptData(txtKeyValue.Text);
                if (enAndDeData.DecryptSingleFile(txtFileInput.Text, txtFileOutput.Text))
                {
                    //MessageBox.Show("Decrypt success!");
                    lbStatus.Text = "Decrypt success!";
                }
                else
                {
                    //MessageBox.Show("Decrypt failed!");
                    lbStatus.Text = "Decrypt failed!";
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtFolderOutput.Text))
                {
                    txtFolderOutput.Text = logic.AutoCreateOutputFolder(txtFolderInput.Text, @"\_decrypt\");
                }

                if (String.IsNullOrEmpty(txtKeyValue.Text))
                {
                    MessageBox.Show("Please input key!");
                    return;
                }

                enAndDeData = new EncryptAndDecryptData.Classes.EncryptAndDecryptData(txtKeyValue.Text);

                // Decrypt all file
                string[] files = Directory.GetFiles(txtFolderInput.Text, "*.*");
                foreach (string file in files)
                {
                    string outputFile = logic.GetOutputFileFromInputFile(file, txtFolderOutput.Text);
                    enAndDeData.DecryptSingleFile(file, outputFile);
                }
                Process.Start(txtFolderOutput.Text);
            }
            enableButton(true);
        }

        private void btnEncryptData_Click(object sender, EventArgs e)
        {
            enableButton(false);
            enAndDeData = new EncryptAndDecryptData.Classes.EncryptAndDecryptData(txtKeyValue.Text);

            if (isFileSelect)
            {
                if (String.IsNullOrEmpty(txtFileInput.Text))
                {
                    MessageBox.Show("Please input input file!");
                    return;
                }

                if (String.IsNullOrEmpty(txtFileOutput.Text))
                {
                    txtFileOutput.Text = logic.AutoCreateOutputFolder(txtFileInput.Text, @"_encrypt\", "dat");
                }

                if (enAndDeData.EncryptSigleFile(txtFileInput.Text, txtFileOutput.Text))
                {
                    //MessageBox.Show("Encrypt success!");
                    lbStatus.Text = "Encrypt success!";
                }
                else
                {
                    //MessageBox.Show("Encrypt failed!");
                    lbStatus.Text = "Encrypt failed!";
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtFolderOutput.Text))
                {
                    
                    txtFolderOutput.Text = logic.AutoCreateOutputFolder(txtFolderInput.Text, @"\_encrypt\");
                }

                // Kiểm tra key đã được input hay chưa?
                if (String.IsNullOrEmpty(txtKeyValue.Text))
                {
                    MessageBox.Show("Please input key!");
                    return;
                }

                // Decrypt all file
                string[] files = Directory.GetFiles(txtFolderInput.Text, "*.*");
                foreach (string file in files)
                {
                    string outputFile = logic.GetOutputFileFromInputFile(file, txtFolderOutput.Text);
                    enAndDeData.EncryptSigleFile(file, outputFile);
                }
                Process.Start(txtFolderOutput.Text);
            }
            enableButton(true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isFileSelect = true;
            txtFileInput.Text = null;
            txtFileOutput.Text = null;
            txtFolderInput.Text = null;
            txtFolderOutput.Text = null;
            txtKeyValue.Text = null;
            btnDecryptData.Enabled = true;
            btnEncryptData.Enabled = true;
            lbStatus.Text = "Ready!";
        }

        private void enableButton(Boolean visible)
        {
            btnDecryptData.Enabled = visible;
            btnEncryptData.Enabled = visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImgShow img = new ImgShow();
            img.IMG = txtFileInput.Text;
            img.ShowDialog();
        }
    }
}
