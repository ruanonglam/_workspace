using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using i_tools.SecurityScreens;

namespace i_tools
{
    public partial class SecutrityScreen : UserControl
    {
        public SecutrityScreen()
        {
            InitializeComponent();
        }

        private void SecutrityScreen_Load(object sender, EventArgs e)
        {
            SecurityPanel.Controls.Clear();
            SecurityPanel.Controls.Add(new PermissionScreen());
        }
    }
}
