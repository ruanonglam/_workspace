using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTools
{
    public partial class FlashScreen : Form
    {
        public FlashScreen()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void manageBackground(bool isHover) 
        {
            if (isHover)
                btnManage.BackColor = Color.FromArgb(13, 155, 131);
            else
                btnManage.BackColor = Color.FromArgb(17, 200, 172);
        }

        private void developBackground(bool isHover)
        {
            if (isHover)
                btnDevelop.BackColor = Color.FromArgb(180, 13, 13);
            else
                btnDevelop.BackColor = Color.FromArgb(246, 16, 16);
        }

        private void shortcutBackground(bool isHover)
        {
            if (isHover)
                btnShortcut.BackColor = Color.FromArgb(103, 44, 126);
            else
                btnShortcut.BackColor = Color.FromArgb(165, 108, 189);
        }

        private void internalBackground(bool isHover)
        {
            if (isHover)
                btnInternal.BackColor = Color.FromArgb(41, 116, 147);
            else
                btnInternal.BackColor = Color.FromArgb(55, 155, 195);
        }

        private void btnManage_MouseHover(object sender, EventArgs e)
        {
            manageBackground(true);
        }

        private void btnManage_MouseLeave(object sender, EventArgs e)
        {
            manageBackground(false);
        }

        private void btnDevelop_MouseHover(object sender, EventArgs e)
        {
            developBackground(true);
        }

        private void btnDevelop_MouseLeave(object sender, EventArgs e)
        {
            developBackground(false);
        }

        private void btnShortcut_MouseHover(object sender, EventArgs e)
        {
            shortcutBackground(true);
        }

        private void btnShortcut_MouseLeave(object sender, EventArgs e)
        {
            shortcutBackground(false);
        }

        private void btnInternal_MouseHover(object sender, EventArgs e)
        {
            internalBackground(true);
        }

        private void btnInternal_MouseLeave(object sender, EventArgs e)
        {
            internalBackground(false);
        }
    }
}
