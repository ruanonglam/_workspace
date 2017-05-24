using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Mutext
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

            Form1 form = new Form1();

            // ADD
            bool createdNew;
            System.Threading.Mutex appMutex = new System.Threading.Mutex(true, "AFTECH.Japanese.MinanoNihongo", out createdNew);
        ///if creation of mutex is successful
        if (createdNew)
        {
            Application.Run(form);
            appMutex.ReleaseMutex();
            GC.KeepAlive(appMutex);
        }
        else
        {
            MessageBox.Show("Application is running!");
        }
        }
    }
}
