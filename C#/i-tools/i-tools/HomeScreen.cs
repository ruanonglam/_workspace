using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using i_tools.Classes;

namespace i_tools
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {

        }

        private void btnWorkFJN_Click(object sender, EventArgs e)
        {
            displayDetailScreen(Constants.DIS_DETAIL_WORK_FJN);
        }

        private void btnFilenFolder_Click(object sender, EventArgs e)
        {
            displayDetailScreen(Constants.DIS_DETAIL_FILE_FOLDER);
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            displayDetailScreen(Constants.DIS_DETAIL_SECURITY);
        }

        private void btnITool_Click(object sender, EventArgs e)
        {
            displayDetailScreen(Constants.DIS_DETAIL_I_TOOL);
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            displayDetailScreen(Constants.DIS_DETAIL_INTERNET);
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            displayDetailScreen(Constants.DIS_DETAIL_FAVORITE);
        }

        private void displayDetailScreen(string screenID)
        {
            CommonVals.BackButton.Visible = true;
            CommonFuncs.displayScreen(screenID);
        }
    }
}
