using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public class Validation
    {
        public Boolean IsNullOrEmpty(String value)
        {
            try
            {
                if (String.IsNullOrEmpty(value))
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            return false;
        }

        public Boolean IsNumberOver(String value, int maxValue)
        {
            try
            {
                if (IsNullOrEmpty(value))
                {
                    if (Int32.Parse(value) > maxValue)
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            { }
            return false;
        }



    }
}
