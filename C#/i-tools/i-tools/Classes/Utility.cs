using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace i_tools.Classes
{
    class Utility
    {

        public static bool IsNullOrEmpty(string val, bool isTrim)
        {
            if (!isTrim)
                return String.IsNullOrEmpty(val);
            else
                return String.IsNullOrEmpty((string)val.Trim());
        }
    }
}
