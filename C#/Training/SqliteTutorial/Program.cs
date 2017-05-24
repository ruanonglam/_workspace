using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SqliteTutorial
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
            Common.Functions.InitForm();
            Application.Run(new MainForm());
        }
    }
}
