using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tescase_.Classes;
using System.IO;

namespace Tescase_
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            CommonVals.MainPanel = this.pnlMain;
            initIconMenu();
            treeSolution.ContextMenuStrip = treeMenu;

            displayTreeSolution(false);
        }

        private void initIconMenu()
        {
            ImageList imgList = new ImageList();
            imgList.Images.Add(Tescase_.Properties.Resources.icon_project);
            imgList.Images.Add(Tescase_.Properties.Resources.icon_config);
            imgList.Images.Add(Tescase_.Properties.Resources.icon_screen);
            imgList.Images.Add(Tescase_.Properties.Resources.icon_db);
            imgList.Images.Add(Tescase_.Properties.Resources.icon_logic);
            imgList.Images.Add(Tescase_.Properties.Resources.icon_io);
            imgList.Images.Add(Tescase_.Properties.Resources.icon_item);
            treeSolution.ImageList = imgList;
        }

        private void createNewProject(string projectName) 
        {
            // Root node
            TreeNode rootNode = new TreeNode(projectName, 0, 0);
            TreeNode config = new TreeNode(Constants.TREE_NODE_CONFIG, 1, 1);
            TreeNode screen = new TreeNode(Constants.TREE_NODE_SCREEN, 2, 2);
            TreeNode db = new TreeNode(Constants.TREE_NODE_DB, 3, 3);
            TreeNode logic = new TreeNode(Constants.TREE_NODE_LOGIC, 4, 4);
            TreeNode io = new TreeNode(Constants.TREE_NODE_IO, 5, 5);
            rootNode.Nodes.Add(config);
            rootNode.Nodes.Add(screen);
            rootNode.Nodes.Add(db);
            rootNode.Nodes.Add(logic);
            rootNode.Nodes.Add(io);

            // Set menu
            config.ContextMenuStrip = nodeConfigMenu;
            rootNode.ContextMenuStrip = rootMenu;

            rootNode.Expand();
            treeSolution.Nodes.Add(rootNode);
            treeSolution.SelectedNode = rootNode;
        }

        private void btnCreateNewPrj_Click(object sender, EventArgs e)
        {
            string projectNameCurrent = CommonVals.ProjectName;
            new DialogAddProject().ShowDialog();
            if (CommonVals.ProjectName == null)
                return;
            createNewProject(CommonVals.ProjectName);

            displayTreeSolution(true);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            
        }

        private void treeSolution_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            treeSolution.SelectedNode = node;

            

            if (node.Parent != null && Constants.TREE_NODE_CONFIG.Equals(node.Parent.Text))
            {
                string projectName = node.Parent.Parent.Text;
                string moduleName = node.Parent.Text;
                string fileName = node.Text;

                string saveConfigFile = CommonVals.ApplicationPath + Constants.DIR_WORK + @"\" + projectName + @"\" + moduleName + @"\" + fileName;
                if (!File.Exists(saveConfigFile))
                {
                    MessageBox.Show("Ini file is not exists! Please input again.");
                    treeSolution.Nodes.Remove(node);
                }
                else
                {
                    pnlMain.Controls.Clear();
                    Config.ConfigScreen configScreen = new Config.ConfigScreen();
                    configScreen.IniDesFileName = fileName;
                    configScreen.ModuleName = moduleName;
                    configScreen.ProjectName = projectName;

                    configScreen.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(configScreen);
                }
            }
        }

        private void treeSolution_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void addNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreateNewPrj_Click(sender, e);
        }

        /// <summary>
        /// Import Ini to program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importIniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dagConfigOpen.ShowDialog();

            string iniSrcPath = dagConfigOpen.FileName;
            string iniSrcFileName = Utility.FileNameFormPath(iniSrcPath);
            string projectName = treeSolution.SelectedNode.Parent.Text;
            string moduleName = treeSolution.SelectedNode.Text;

            if (importIniData(iniSrcPath, projectName, moduleName, iniSrcFileName))
            {
                // Create Node To TreeNode
                TreeNode node = treeSolution.SelectedNode;
                node.Nodes.Add(new TreeNode(iniSrcFileName, 6, 6));
                node.Expand();
            }
        }

        private void writeDataToIni(string section, string saveConfigFile)
        {
            IniOperator iniOperator = new IniOperator(saveConfigFile);

            section = section.Replace("[", "$");
            section = section.Replace("]", "%");

            //
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_CMM_DATATYPE, Constants.BOOL_STRING);
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_CMM_REQUIRED, Constants.BOOL_TRUE);

            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_ISPATH, Constants.BOOL_TRUE);
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_AUTOCREATEPATH, Constants.BOOL_TRUE);
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_COLLECTIONVAL, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_DEFAULTVAL, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_ERRORMESSAGE, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_ERRORLOG, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_INFOLOG, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_EXITPG1, Constants.BOOL_TRUE);
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_EXITPG2, Constants.BOOL_FALSE);
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_OTHERPC1, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_STR_OTHERPC2, "");

            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_MINVAL, "0");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_MAXVAL, "10");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_COLLECTIONVAL, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_ERRORMESSAGE, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_ERRORLOG, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_INFOLOG, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_DEFAULTVAL, "0");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_EXITPG1, Constants.BOOL_TRUE);
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_EXITPG2, Constants.BOOL_FALSE);
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_OTHERPC1, "");
            iniOperator.IniWriteValue(section, Constants.CONFIG_SAVE_NUM_OTHERPC2, "");
        }

        private bool importIniData(string iniSrcPath, string projectName, string moduleName, string iniDesFilename)
        {
            Dictionary<string, Dictionary<string, string>> iniData = 
                new Dictionary<string, Dictionary<string, string>>();
            try
            {
                if (File.Exists(iniSrcPath))
                {
                    // Create temp folder, if not exist
                    string configFolder = CommonVals.ApplicationPath + Constants.DIR_WORK + @"\" + projectName;
                    string moduleFolder = configFolder + @"\" + moduleName;
                    Directory.CreateDirectory(moduleFolder);

                    string iniDesPath = moduleFolder + @"\" + iniDesFilename;
                    if (!File.Exists(iniDesPath))
                        File.Create(iniDesPath).Close();
                    else
                        return false;

                    IniOperator iniOperator = new IniOperator(iniDesPath);
                    Dictionary<string, string> inputIniConfig = new IniParser().ReadIniFile(iniSrcPath);
                    foreach (string key in inputIniConfig.Keys)
                    {
                        iniOperator.IniWriteValue(iniSrcPath, "_" + key, "String");
                        iniData.Add(key, createNewDefaultConfigItem());
                    }
                    string iniKey = projectName + moduleName + iniDesFilename;
                    CommonVals.IniConfigData.Add(iniKey, iniData);
                    return true;
                }
            }
            catch (Exception)
            { }
            return false;
        }

        private Dictionary<string, string> createNewDefaultConfigItem()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            result.Add(Constants.CONFIG_SAVE_CMM_DATATYPE, Constants.BOOL_STRING);
            result.Add(Constants.CONFIG_SAVE_CMM_REQUIRED, Constants.BOOL_TRUE);

            result.Add(Constants.CONFIG_SAVE_STR_ISPATH, Constants.BOOL_TRUE);
            result.Add(Constants.CONFIG_SAVE_STR_AUTOCREATEPATH, Constants.BOOL_TRUE);
            result.Add(Constants.CONFIG_SAVE_STR_COLLECTIONVAL, "");
            result.Add(Constants.CONFIG_SAVE_STR_DEFAULTVAL, "");
            result.Add(Constants.CONFIG_SAVE_STR_ERRORMESSAGE, "");
            result.Add(Constants.CONFIG_SAVE_STR_ERRORLOG, "");
            result.Add(Constants.CONFIG_SAVE_STR_INFOLOG, "");
            result.Add(Constants.CONFIG_SAVE_STR_EXITPG1, Constants.BOOL_TRUE);
            result.Add(Constants.CONFIG_SAVE_STR_EXITPG2, Constants.BOOL_FALSE);
            result.Add(Constants.CONFIG_SAVE_STR_OTHERPC1, "");
            result.Add(Constants.CONFIG_SAVE_STR_OTHERPC2, "");

            result.Add(Constants.CONFIG_SAVE_NUM_MINVAL, "0");
            result.Add(Constants.CONFIG_SAVE_NUM_MAXVAL, "10");
            result.Add(Constants.CONFIG_SAVE_NUM_COLLECTIONVAL, "");
            result.Add(Constants.CONFIG_SAVE_NUM_ERRORMESSAGE, "");
            result.Add(Constants.CONFIG_SAVE_NUM_ERRORLOG, "");
            result.Add(Constants.CONFIG_SAVE_NUM_INFOLOG, "");
            result.Add(Constants.CONFIG_SAVE_NUM_DEFAULTVAL, "0");
            result.Add(Constants.CONFIG_SAVE_NUM_EXITPG1, Constants.BOOL_TRUE);
            result.Add(Constants.CONFIG_SAVE_NUM_EXITPG2, Constants.BOOL_FALSE);
            result.Add(Constants.CONFIG_SAVE_NUM_OTHERPC1, "");
            result.Add(Constants.CONFIG_SAVE_NUM_OTHERPC2, "");

            return result;
        }

        private void displayTreeSolution(bool isDisplay)
        {
            pcTreeHeader.Visible = isDisplay;
            if(!isDisplay)
                treeSolution.BorderStyle = BorderStyle.None;
            else
                treeSolution.BorderStyle = BorderStyle.Fixed3D;
        }

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string saveConfigFile = CommonVals.ApplicationPath + Constants.DIR_WORK;
                Directory.Delete(saveConfigFile, true);
            }
            catch (Exception) { }
        }
    }
}
