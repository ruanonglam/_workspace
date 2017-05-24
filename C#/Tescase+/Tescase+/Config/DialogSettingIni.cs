using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tescase_.Classes;

namespace Tescase_.Config
{
    public partial class DialogSettingIni : Form
    {
        // 0: NumberScreen
        // 1: StringScreen
        private int screenTypeDisplay = Constants.INT_NUMBER;
        Dictionary<string, Dictionary<string, string>> iniDataInit = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, Dictionary<string, string>> iniData = new Dictionary<string, Dictionary<string, string>>();
        StringEditorScreen stringScreen = new StringEditorScreen();
        NumberEditorScreen numberScreen = new NumberEditorScreen();
        string currentPropertiesKey = null;
        string iniKey = null;

        private string iniDesFileName;
        private string moduleName;
        private string projectName;

        public string IniDesFileName
        {
            set { iniDesFileName = value; }
        }
        public string ModuleName
        {
            set { moduleName = value; }
        }
        public string ProjectName
        {
            set { projectName = value; }
        }

        public DialogSettingIni()
        {
            InitializeComponent();
        }

        private void DialogSettingIni_Load(object sender, EventArgs e)
        {
            iniKey = projectName + moduleName + iniDesFileName;
            CommonVals.IniConfigData.TryGetValue(iniKey, out iniDataInit);
            this.Text = "Config - " + iniDesFileName;
            bindDataToDGV(null);
        }

        private string isStringOrNumber(string value)
        {
            if (Constants.BOOL_STRING.Equals(value))
                return Constants.VAL_STRING;
            else
                return Constants.VAL_NUMBER;
        }

        private int isEditorScreen(string value)
        {
            if (Constants.VAL_STRING.Equals(value))
                return Constants.INT_STRING;
            else
                return Constants.INT_NUMBER;
        }

        private void bindDataToDGV(string propertiesName)
        {
            int rowDisplayEditor = 0;
            CommonVals.IniConfigData.TryGetValue(iniKey, out iniData);

            dgvKeys.Rows.Clear();
            foreach (string key in iniData.Keys)
            {
                int rowIndex = dgvKeys.Rows.Add();

                if (propertiesName != null && propertiesName.Equals(key))
                    rowDisplayEditor = rowIndex;

                dgvKeys.Rows[rowIndex].Cells["clnName"].Value = key;
                dgvKeys.Rows[rowIndex].Cells["clnDataType"].Value =
                    isStringOrNumber(iniData[key][Constants.CONFIG_SAVE_CMM_DATATYPE]);
            }
            dgvKeys.Rows[rowDisplayEditor].Selected = true;
            string currentPropertiesName = (string)dgvKeys.Rows[rowDisplayEditor].Cells["clnName"].Value;
            int currentScreenTypeDiplay = isEditorScreen((string)dgvKeys.Rows[rowDisplayEditor].Cells["clnDataType"].Value);
            displayEditorScreen(currentScreenTypeDiplay, currentPropertiesName);
        }

        private void btnSwitchDataType_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> currentItem = null;
            int dataType = Constants.INT_NUMBER;
            if (screenTypeDisplay == Constants.INT_STRING)
            {
                currentItem = stringScreen.GetDataFromEditor();
                dataType = Constants.INT_NUMBER;
            }
            else
            {
                currentItem = numberScreen.GetDataFromEditor();
                dataType = Constants.INT_STRING;
            }
            currentItem[Constants.CONFIG_SAVE_CMM_DATATYPE] = dataType.ToString();
            screenTypeDisplay = dataType;
            iniData[currentPropertiesKey] = currentItem;
            CommonVals.IniConfigData[iniKey] = iniData;
            bindDataToDGV(currentPropertiesKey);
        }

        private void displayEditorScreen(int screenType, string propertiesName)
        {
            Dictionary<string, string> iniItemConfig = new Dictionary<string, string>();
            iniData.TryGetValue(propertiesName, out iniItemConfig);

            pnlContentEditor.Controls.Clear();
            if (screenType == 0)
            {
                numberScreen.BindDatoToForm(iniItemConfig);
                pnlContentEditor.Controls.Add(numberScreen);
                lbDatatype.Text = "(Datatype = Number)";
            }
            else
            {
                stringScreen.BindDatoToForm(iniItemConfig);
                pnlContentEditor.Controls.Add(stringScreen);
                lbDatatype.Text = "   (Datatype = String)";
            }
            if (!String.IsNullOrEmpty(propertiesName))
                lbItemName.Text = propertiesName + " properties:";

            screenTypeDisplay = screenType;
            currentPropertiesKey = propertiesName;
        }

        private void dgvKeys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string key = (string)dgvKeys.Rows[e.RowIndex].Cells["clnName"].Value;
            saveIniConfig(key, false);
        }

        private void saveIniConfig(string propertiesKey, bool isCloseScreen)
        {
            Dictionary<string, string> currentItem = null;
            if (screenTypeDisplay == Constants.INT_STRING)
                currentItem = stringScreen.GetDataFromEditor();
            else
                currentItem = numberScreen.GetDataFromEditor();

            currentItem[Constants.CONFIG_SAVE_CMM_DATATYPE] = screenTypeDisplay.ToString();
            iniData[currentPropertiesKey] = currentItem;
            CommonVals.IniConfigData[iniKey] = iniData;
            if (!isCloseScreen)
                bindDataToDGV(propertiesKey);
        }

        private void btnSaveIniConfig_Click(object sender, EventArgs e)
        {
            saveIniConfig(null, true);
            this.Close();
        }

        private void btnCancelIniConfig_Click(object sender, EventArgs e)
        {
            // Giải pháp. Đọc Data từ FileSave
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            saveIniConfig(null, true);
            DialogConfigPreview previewDialog = new DialogConfigPreview();
            previewDialog.IniDesFileName = iniDesFileName;
            previewDialog.setIniData(iniData);

            previewDialog.ShowDialog();
        }
    }
}
