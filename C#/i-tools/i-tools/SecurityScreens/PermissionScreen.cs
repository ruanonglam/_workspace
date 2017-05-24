using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using i_tools.Classes;
using i_tools.Classes.Security;
using System.Security.AccessControl;

namespace i_tools.SecurityScreens
{
    public partial class PermissionScreen : UserControl
    {
        private char SPLIT_GROUPT = ',';

        private string domain = null;
        private string[] group = null;
        SecurityOperator securityOperator = null;

        public PermissionScreen()
        {
            InitializeComponent();
        }

        private void PermissionScreen_Load(object sender, EventArgs e)
        {
            securityOperator = new SecurityOperator();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            domain = IniOperator.IniReadValue(Constants.SECURITY_PERMISSION_SECTION, Constants.SECURITY_PERMISSION_ITEM_DOMAIN);
            if (!Utility.IsNullOrEmpty(domain, true))
                domain += @"\";

            // Validate
            if (Utility.IsNullOrEmpty(txtFolders.Text, true))
            {
                CommonVals.MessageBox.showMessage(Constants.MESSAGE_TYPE_ERROR);
                return;
            }
            if (Utility.IsNullOrEmpty(txtFolders.Text, true))
            {
                CommonVals.MessageBox.showMessage(Constants.MESSAGE_TYPE_ERROR);
                return;
            }
            
            // Main process
            string[] folders = txtFolders.Lines;
            string[] accounts = txtGroup.Lines;
            bool exeResult = false;
            if (radNone.Checked)
                exeResult = removePermission(folders, accounts, domain);
            else
                exeResult = setPermission(folders, accounts, domain, getPermission());

            // Result
            if (exeResult)
                CommonVals.MessageBox.showMessage(Constants.MESSAGE_TYPE_INFO);
            else
                CommonVals.MessageBox.showMessage(Constants.MESSAGE_TYPE_ERROR);
        }

        private FileSystemRights getPermission()
        {
            if (radFull.Checked)
                return FileSystemRights.FullControl;
            else if (radWrite.Checked)
                return FileSystemRights.Modify;
            else
                return FileSystemRights.ReadAndExecute;
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            // Get members from ini file.
            group = setDataFromGroupToTextBox(IniOperator.IniReadValue(Constants.SECURITY_PERMISSION_SECTION, Constants.SECURITY_PERMISSION_ITEM_GROUP));
            // Set memers to texbox Members
            txtGroup.Lines = group;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonFuncs.displayHomeScreen();
        }

        /// <summary>
        /// Set data from input string to textbox Members.
        /// </summary>
        /// <param name="groupVals"></param>
        /// <returns></returns>
        private string[] setDataFromGroupToTextBox(string groupVals)
        {
            if (groupVals != null)
                return groupVals.Split(SPLIT_GROUPT);
            return null;
        }

        private bool setPermission(string[] folders, string[] accounts, string domain, FileSystemRights rights)
        {
            int result = 0;
            int totalRecord = 0;
            try
            {
                foreach (string folder in folders)
                {
                    foreach (string account in accounts)
                    {
                        bool exeResult = securityOperator.setPermission(folder, domain + account, rights);
                        if (exeResult)
                            result++;
                        totalRecord++;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            if (result < totalRecord)
                return false;
            return true;
        }

        private bool removePermission(string[] folders, string[] accounts, string domain)
        {
            int result = 0;
            int totalRecord = 0;
            try
            {
                foreach (string folder in folders)
                {
                    foreach (string account in accounts)
                    {
                        bool exeResult = securityOperator.removeFullPermission(folder, domain + account);
                        if (exeResult)
                            result++;
                        totalRecord++;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            if (result < totalRecord)
                return false;
            return true;
        }
        
    }
}
