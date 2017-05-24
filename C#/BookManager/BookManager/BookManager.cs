using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManager.Screen;

namespace BookManager
{
    public partial class BookManager : Form
    {
        private Boolean isBtnMenuClicked = false;
        public BookManager()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = !isBtnMenuClicked;
            isBtnMenuClicked = !isBtnMenuClicked;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();
            HomeScreen home = new HomeScreen();
            pnlMainContent.Controls.Add(home);
            home.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            home.Dock = DockStyle.Fill;
        }
    }
}
