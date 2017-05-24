using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tescase_.Genrator;

namespace Tescase_.Config
{
    public partial class DialogConfigPreview : Form
    {
        Dictionary<string, Dictionary<string, string>> iniData = new Dictionary<string, Dictionary<string, string>>();
        private string iniDesFileName;

        public string IniDesFileName
        {
            set { iniDesFileName = value; }
        }

        public void setIniData(Dictionary<string, Dictionary<string, string>> iniDataVal)
        {
            iniData = iniDataVal;
        }

        public DialogConfigPreview()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DialogConfigPreview_Load(object sender, EventArgs e)
        {
            this.Text = "Preview - " + iniDesFileName;
            TestcaseConfig generate = new TestcaseConfig(iniDesFileName);
            ricPreviewContent.Text = generate.GenerateData(iniData);
        }
    }
}
