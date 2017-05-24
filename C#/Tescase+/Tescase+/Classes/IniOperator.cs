using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Tescase_.Classes
{
    class IniOperator
    {
        public string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        [DllImport("KERNEL32.DLL", EntryPoint = "GetPrivateProfileStringW", 
            SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, 
            CallingConvention = CallingConvention.StdCall)]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, 
            string lpDefault, string lpReturnString, int nSize, string lpFilename);

        public IniOperator(string INIPath)
        {
            path = INIPath;
        }

        public void IniWriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, this.path);
        }

        public string IniReadValue(string section, string key)
        {
            StringBuilder result = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", result, 255, this.path);
            return result.ToString();
        }

        public List<string> IniReadAllItemInSection(string section)
        {
            String result = new String(' ', 32000);
            GetPrivateProfileString(section, null, "", result, 32000, this.path);

            List<string> stuff = new List<string>(result.Split('\0'));
            stuff.RemoveRange(stuff.Count - 2, 2);

            return stuff;
        }

        public bool IsExistedInFile(string section, string key)
        {
            StringBuilder resVal = new StringBuilder(255);
            int result = GetPrivateProfileString(section, key, "", resVal, 255, this.path);
            if (result > 0)
                return true;
            return false;
        }
    }
}
