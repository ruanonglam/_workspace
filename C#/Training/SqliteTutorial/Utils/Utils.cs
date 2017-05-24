using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SqliteTutorial.Utils
{
    class Utils
    {

        public static int CountFileInFolder(String path) {
            return Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories).Length;
        }
    }
}
