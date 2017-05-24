using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tescase_.Classes
{
    class Utility
    {

        public static string FileNameFormPath(string path)
        {
            if (null != path)
            {
                string[] tokens = path.Split('\\');
                return tokens[tokens.Length - 1];
            }
            return null;
        }

        public static bool IsNumber(string val)
        {
            try
            {
                if (String.IsNullOrEmpty(val))
                    return false;
                Int32.Parse(val);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsNullOrEmpty(string val)
        {
            try
            {
                if (String.IsNullOrEmpty(val))
                    return true;
                else
                    if (String.IsNullOrEmpty(val.Trim()))
                        return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
    }
}
