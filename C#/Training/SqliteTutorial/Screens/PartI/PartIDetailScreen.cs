using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqliteTutorial.Screens.PartI
{
    public partial class PartIDetailScreen : UserControl
    {
        public PartIDetailScreen()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Common.Functions.SetScreen(Common.DataLoaded.PartIScreen);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Common.Functions.getPage(Common.Constants.VIEW_NEXT);
            displayPage();
            this.detail_view.Image = Utils.Images.ByteToImage(Common.Functions.getImageFileName());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Common.Functions.getPage(Common.Constants.VIEW_PREV);
            displayPage();
            this.detail_view.Image = Utils.Images.ByteToImage(Common.Functions.getImageFileName());
        }

        private void PartIDetailScreen_Load(object sender, EventArgs e)
        {
            displayPage();
        }

        private void displayPage() {
            this.pages.Text = Common.DataLoaded.CurrentPage + "/" + Common.DataLoaded.TotalPages;
        }

        
    }
}
