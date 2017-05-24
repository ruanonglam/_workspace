using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using i_tools.Classes;

namespace i_tools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CommonFuncs.initControl();
            Application.Run(new MainForm());
        }
    }
}
