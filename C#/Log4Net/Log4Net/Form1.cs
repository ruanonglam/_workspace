using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
//[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4Net
{
    public partial class Form1 : Form
    {
        ILog log = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            log.Debug("Testing");
            log.Info("Testing");
            log.Warn("Testing");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
