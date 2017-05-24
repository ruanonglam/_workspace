using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tescase_.Classes;

namespace Tescase_
{
    public partial class DialogAddProject : Form
    {
        public DialogAddProject()
        {
            InitializeComponent();
        }

        private void DialogAddProject_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addProject();
        }

        private void addProject()
        {
            if (!String.IsNullOrEmpty(txtProjectName.Text.Trim()))
            {
                if (isValidProjectName(txtProjectName.Text.Trim()))
                    CommonVals.ProjectName = txtProjectName.Text;
                this.Close();
            }
            else
            {
                txtProjectName.Focus();
            }
        }

        private bool isValidProjectName(string name)
        {
            try
            {
                CommonVals.Projects.Add(name, name);
                return true;
            }
            catch (ArgumentNullException ane)
            {
            }
            catch (ArgumentException ae)
            {
            }
            CommonVals.ProjectName = null;
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonVals.ProjectName = null;
            this.Close();
        }

        private void txtProjectName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addProject();
        }
    }
}
