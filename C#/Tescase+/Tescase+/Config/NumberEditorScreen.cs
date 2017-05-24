using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tescase_.Classes;

namespace Tescase_.Config
{
    public partial class NumberEditorScreen : UserControl
    {
        private Dictionary<string, string> currentItem = null;

        public NumberEditorScreen()
        {
            InitializeComponent();
        }

        private void NumberEditorScreen_Load(object sender, EventArgs e)
        {
            chkRequired_CheckStateChanged(sender, e);
        }

        public void BindDatoToForm(Dictionary<string, string> iniData)
        {
            currentItem = iniData;
            // Setting Data Section:
            string isRequired = valueOfKey(chkRequired.Tag.ToString(), iniData);
            if (Constants.BOOL_TRUE.Equals(isRequired))
                chkRequired.Checked = true;
            else
                chkRequired.Checked = false;

            txtMinVal.Text = valueOfKey(txtMinVal.Tag.ToString(), iniData);
            txtMaxVal.Text = valueOfKey(txtMaxVal.Tag.ToString(), iniData);
            txtCollectionVals.Text = valueOfKey(txtCollectionVals.Tag.ToString(), iniData);

            // Required Section
            txtErrorMessage.Text = valueOfKey(txtErrorMessage.Tag.ToString(), iniData);
            txtErrorLog.Text = valueOfKey(txtErrorLog.Tag.ToString(), iniData);
            string isExit1 = valueOfKey(chkExitPG1.Tag.ToString(), iniData);
            if (Constants.BOOL_TRUE.Equals(isExit1))
                chkExitPG1.Checked = true;
            else
                chkExitPG1.Checked = false;

            txtOtherPC1.Text = valueOfKey(txtOtherPC1.Tag.ToString(), iniData);

            // Not Required Section
            txtDefaultVal.Text = valueOfKey(txtDefaultVal.Tag.ToString(), iniData);
            txtInfoLog.Text = valueOfKey(txtInfoLog.Tag.ToString(), iniData);
            string isExit2 = valueOfKey(chkExitPG2.Tag.ToString(), iniData);
            if (Constants.BOOL_TRUE.Equals(isExit2))
                chkExitPG2.Checked = true;
            else
                chkExitPG2.Checked = false;

            txtOtherPC2.Text = valueOfKey(txtOtherPC2.Tag.ToString(), iniData);
        }

        private string valueOfKey(string key, Dictionary<string, string> iniData)
        {
            string result = "";
            iniData.TryGetValue(key, out result);
            return result;
        }

        public Dictionary<string, string> GetDataFromEditor()
        {
            // Setting Data Section:
            if (chkRequired.Checked)
                currentItem[chkRequired.Tag.ToString()] = Constants.BOOL_TRUE;
            else
                currentItem[chkRequired.Tag.ToString()] = Constants.BOOL_FALSE;

            currentItem[txtMinVal.Tag.ToString()] = txtMinVal.Text;
            currentItem[txtMaxVal.Tag.ToString()] = txtMaxVal.Text;
            currentItem[txtCollectionVals.Tag.ToString()] = txtCollectionVals.Text;

            // Required Section
            currentItem[txtErrorMessage.Tag.ToString()] = txtErrorMessage.Text;
            currentItem[txtErrorLog.Tag.ToString()] = txtErrorLog.Text;

            if (chkExitPG1.Checked)
                currentItem[chkExitPG1.Tag.ToString()] = Constants.BOOL_TRUE;
            else
                currentItem[chkExitPG1.Tag.ToString()] = Constants.BOOL_FALSE;

            currentItem[txtOtherPC1.Tag.ToString()] = txtOtherPC1.Text;

            // Not Required Section
            currentItem[txtDefaultVal.Tag.ToString()] = txtDefaultVal.Text;
            currentItem[txtInfoLog.Tag.ToString()] = txtInfoLog.Text;

            if (chkExitPG2.Checked)
                currentItem[chkExitPG2.Tag.ToString()] = Constants.BOOL_TRUE;
            else
                currentItem[chkExitPG2.Tag.ToString()] = Constants.BOOL_FALSE;

            currentItem[txtOtherPC2.Tag.ToString()] = txtOtherPC2.Text;

            return currentItem;
        }

        private void chkRequired_CheckStateChanged(object sender, EventArgs e)
        {
            setEnableToReuiredControl(chkRequired.Checked);
            setEnableToNotReuiredControl(!chkRequired.Checked);
        }

        private void setEnableToReuiredControl(bool isEnable)
        {
            pnlTitle1.Enabled = isEnable;
            pnlLine1_1.Enabled = isEnable;
            pnlLine1_2.Enabled = isEnable;
            pnlLine1_3.Enabled = isEnable;
            pnlLine1_4.Enabled = isEnable;
        }

        private void setEnableToNotReuiredControl(bool isEnable)
        {
            pnlTitle2.Enabled = isEnable;
            pnlLine2_1.Enabled = isEnable;
            pnlLine2_2.Enabled = isEnable;
            pnlLine2_3.Enabled = isEnable;
            pnlLine2_4.Enabled = isEnable;
        }
    }
}
