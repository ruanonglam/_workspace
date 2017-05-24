using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqliteTutorial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Common.DataLoaded.MainPanel = this.MainPanel;
            Common.Functions.SetScreen(Common.DataLoaded.HomeScreen);
        }
    }
}
