using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using i_tools.Classes;

namespace i_tools
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CommonVals.BackButton = this.btnBack;
            CommonVals.MainPanel = this.MainPanel;
            CommonFuncs.displayScreen(CommonVals.HomeScreen);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            CommonVals.BackButton.Visible = true;
            CommonFuncs.displayScreen(CommonVals.SettingScreen);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CommonVals.BackButton.Visible = false;
            CommonFuncs.displayScreen(CommonVals.HomeScreen);
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
