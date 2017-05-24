using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace i_tools
{
    public partial class SettingScreen : UserControl
    {
        public SettingScreen()
        {
            InitializeComponent();
        }

        private void SettingScreen_Load(object sender, EventArgs e)
        {
            SettingPanel.Controls.Clear();
            SettingPanel.Controls.Add(new SettingScreens.SecuritySettingScreen());
        }
    }
}
