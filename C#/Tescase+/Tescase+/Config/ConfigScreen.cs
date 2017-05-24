using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tescase_.Classes;
using System.IO;

namespace Tescase_.Config
{
    public partial class ConfigScreen : UserControl
    {
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


        public ConfigScreen()
        {
            InitializeComponent();
        }

        private void ConfigScreen_Load(object sender, EventArgs e)
        {
            bindDataToDGV();
            lbTitle.Text = "Config - " + iniDesFileName;
        }

        private void bindDataToDGV()
        {
            //IniOperator iniOperator = new IniOperator(iniDesFileName);
            //List<string> inputIniConfig = iniOperator.IniReadAllItemInSection(sectionName);

            string key = projectName + moduleName + iniDesFileName;
            Dictionary<string, Dictionary<string, string>> iniData =
                new Dictionary<string, Dictionary<string, string>>();
            CommonVals.IniConfigData.TryGetValue(key, out iniData);

            dgvIniConfig.Rows.Clear();
            int index = 1;
            foreach (string iniKey in iniData.Keys) 
            {
                int rowIndex = dgvIniConfig.Rows.Add();
                string keyVal = iniKey.Substring(1, iniKey.Length - 1);
                dgvIniConfig.Rows[rowIndex].Cells["clnNo"].Value = index;
                dgvIniConfig.Rows[rowIndex].Cells["clnName"].Value = keyVal;
                index++;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CommonFuncs.DisplayHomeScreen();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            // Open dialog
            Config.DialogSettingIni configScreen = new Config.DialogSettingIni();
            configScreen.IniDesFileName = iniDesFileName;
            configScreen.ModuleName = moduleName;
            configScreen.ProjectName = projectName;
            configScreen.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            new DialogExportFile().ShowDialog();
        }
    }
}
