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
    public partial class PartIScreen : UserControl
    {
        public PartIScreen()
        {
            InitializeComponent();
            // Init form
            //Common.Functions.InitPartIForm();

           // Common.DataLoaded.PartIMainMainPanel = this.PartIMainMainPanel;
            //Common.Functions.setPartIScreen(Common.DataLoaded.PartIHomeScreen);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Common.Functions.SetScreen(Common.DataLoaded.HomeScreen);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Common.DataLoaded.TotalPages = Utils.Utils.CountFileInFolder(Common.Constants.IMG_URL);
            Common.Functions.SetScreen(Common.DataLoaded.PartIDetailScreen);
        }
    }
}
