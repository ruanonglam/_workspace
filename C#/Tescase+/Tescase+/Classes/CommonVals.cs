using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tescase_.Classes
{
    class CommonVals
    {
        public static string ApplicationPath = AppDomain.CurrentDomain.BaseDirectory;

        // Common
        public static Panel MainPanel = null;

        // Add repoject
        public static string ProjectName = null;
        public static Dictionary<string, string> Projects = new Dictionary<string, string>();
    
        // Import Config
        public static Dictionary<string, Dictionary<string, Dictionary<string, string>>> IniConfigData = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();

    }
}
