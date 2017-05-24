using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Tescase_.Classes;

namespace Tescase_
{
    public partial class DialogImportIniFile : Form
    {
        public DialogImportIniFile()
        {
            InitializeComponent();
        }

        private void txtIniPath_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = dagConfigOpen.ShowDialog();
            txtIniPath.Text = dagConfigOpen.FileName;
            
        }

        //private bool isValidPath(string path)
        //{
        //    try
        //    {
        //        if (File.Exists(path))
        //        {
        //            string fileName = Utility.FileNameFormPath(dagConfigOpen.FileName);
        //            CommonVals.IniImportFiles.Add(CommonVals.NodeSelected + fileName, dagConfigOpen.FileName);
        //            return true;
        //        }
        //    }
        //    catch (Exception)
        //    { 
                
        //    }
        //    return false;
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //CommonVals.IniImportPath = null;
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //if (isValidPath(txtIniPath.Text))
            //    CommonVals.IniImportPath = txtIniPath.Text;
            //else
            //    CommonVals.IniImportPath = null;
            //this.Close();
        }

        private void DialogImportIniFile_Load(object sender, EventArgs e)
        {
            btnCancel.Select();
        }
    }
}
