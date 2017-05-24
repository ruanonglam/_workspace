using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace SetPermission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (removePermission(txtAccount.Text, txtFolder.Text))
            {
                MessageBox.Show("Remove permission OK!");
            }
            else {
                MessageBox.Show("Remove permission NG!");
            }
        }

        private void btnSetFull_Click(object sender, EventArgs e)
        {
            if (setPermission(txtAccount.Text, txtFolder.Text))
            {
                MessageBox.Show("Setting permission OK!");
            }
            else
            {
                MessageBox.Show("Setting permission NG!");
            }
        }

        private bool removePermission(string account, string path)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();

                directorySecurity.RemoveAccessRule(new FileSystemAccessRule(account,
                    FileSystemRights.FullControl,
                    InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                    PropagationFlags.None,
                    AccessControlType.Allow));
                directoryInfo.SetAccessControl(directorySecurity);
                
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private bool setPermission(string account, string path)
        {
            try
            {
                removePermission(account, path);

                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();

                directorySecurity.AddAccessRule(new FileSystemAccessRule(account,
                        FileSystemRights.FullControl,
                        InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                        PropagationFlags.None,
                        AccessControlType.Allow));
                directoryInfo.SetAccessControl(directorySecurity);
                
            }
            catch (Exception)
            {
                return false;
            }
            return true;
            
        }
    }
}
