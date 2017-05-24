using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using i_tools.Classes;

namespace i_tools.SettingScreens
{
    public partial class SecuritySettingScreen : UserControl
    {
        private char SPLIT_GROUPT = ',';
        private string INVALID_VAL = "#i#";
        private string domain = null;
        private string group = null;
        public SecuritySettingScreen()
        {
            InitializeComponent();
        }

        private void SecuritySettingScreen_Load(object sender, EventArgs e)
        {
            domain = IniOperator.IniReadValue(Constants.SECURITY_PERMISSION_SECTION, Constants.SECURITY_PERMISSION_ITEM_DOMAIN);
            group = IniOperator.IniReadValue(Constants.SECURITY_PERMISSION_SECTION, Constants.SECURITY_PERMISSION_ITEM_GROUP);
            setDataFromGroupToTextBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string groupData = getDataFromMultiTextBox();
            if (!INVALID_VAL.Equals(groupData))
            {
                IniOperator.IniWriteValue(Constants.SECURITY_PERMISSION_SECTION,
                    Constants.SECURITY_PERMISSION_ITEM_DOMAIN, txtDomain.Text);
                IniOperator.IniWriteValue(Constants.SECURITY_PERMISSION_SECTION,
                    Constants.SECURITY_PERMISSION_ITEM_GROUP, groupData);
                domain = txtDomain.Text;
                group = groupData;
                CommonVals.MessageBox.showMessage(Constants.MESSAGE_TYPE_INFO);
            }
            else
            {
                CommonVals.MessageBox.showMessage(Constants.MESSAGE_TYPE_ERROR);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setDataFromGroupToTextBox();
        }

        private string getDataFromMultiTextBox()
        {
            string result = null;
            int index = 0;
            string[] lines = txtGroup.Lines;
            foreach(string line in lines)
            {
                if (line.Contains(SPLIT_GROUPT))
                    return INVALID_VAL;
                if (index == 0)
                    result = line;
                else
                    result += SPLIT_GROUPT + line;
                index++;
            }
            return result;
        }
        private void setDataFromGroupToTextBox()
        {
            string[] result = null;
            txtDomain.Text = domain;
            if (group != null)
                result = group.Split(SPLIT_GROUPT);
            txtGroup.Lines = result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CommonFuncs.displayHomeScreen();
        }
    }
}
