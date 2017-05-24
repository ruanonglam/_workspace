using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqliteTutorial
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Common.Functions.SetScreen(Common.DataLoaded.PartIScreen);
        }
    }
}
