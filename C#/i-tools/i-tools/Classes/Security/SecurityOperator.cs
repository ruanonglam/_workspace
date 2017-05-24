using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.AccessControl;
using System.IO;
using System.Security.Principal;

namespace i_tools.Classes.Security
{
    class SecurityOperator
    {

        public bool setPermission(string folder, string account, FileSystemRights rights)
        {
            try
            {
                // Fails to remove permission
                if (!removeFullPermission(folder, account))
                    return false;

                // Success to remove permission.
                // Set to permission
                DirectoryInfo directoryInfo = new DirectoryInfo(folder);
                DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();

                directorySecurity.AddAccessRule(new FileSystemAccessRule(account,
                        rights, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                        PropagationFlags.None, AccessControlType.Allow));
                directoryInfo.SetAccessControl(directorySecurity);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool removeFullPermission(string folder, string account)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folder);
                DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();

                directorySecurity.RemoveAccessRule(new FileSystemAccessRule(account,
                    FileSystemRights.FullControl,
                    InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                    PropagationFlags.None,
                    AccessControlType.Allow));
                directoryInfo.SetAccessControl(directorySecurity);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }
}
