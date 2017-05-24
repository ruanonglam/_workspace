using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tescase_.Classes
{
    class IniParser
    {
        public Dictionary<string, string> ReadIniFile(string iniFile)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            try
            {
                if (File.Exists(iniFile))
                {
                    string section = null;
                    foreach (string line in File.ReadAllLines(iniFile))
                    {
                        if (isComment(line))
                            continue;
                        if (isSection(line))
                        {
                            section = line;
                            continue;
                        }

                        if (isItem(line))
                        {
                            string item = getItemVal(line);
                            string key = getKey(section, item);
                            if (key != null && !isKeyExists(key, result))
                                result.Add(key.Trim(), item);
                        }
                    }
                    return result;
                }
            }
            catch (Exception)
            { }
            return null;
        }

        #region ValidateConfigItem
        private bool isSection(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                if (value.StartsWith("[") && value.EndsWith("]"))
                {
                    return true;
                }
            }
            return false;
        }

        private bool isComment(string value)
        {
            if (!String.IsNullOrEmpty(value) && value.StartsWith(";"))
                return true;
            return false;
        }

        private bool isItem(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                if (!value.StartsWith("=") && value.Contains("="))
                    return true;

            }
            return false;
        }

        #endregion ValidateConfigItem

        private string getItemVal(string line)
        {
            try
            {
                int position = line.IndexOf("=");
                return line.Substring(0, position);
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

        private string getKey(string section, string item)
        {
            if (String.IsNullOrEmpty(section) && !String.IsNullOrEmpty(item))
                return item;
            if (!String.IsNullOrEmpty(section) && !String.IsNullOrEmpty(item))
                return section + item;
            return null;
        }

        private bool isKeyExists(string key, Dictionary<string, string> dictionary)
        {
            if (!String.IsNullOrEmpty(key) && dictionary.ContainsKey(key))
                return true;
            return false;
        }
    }
}
