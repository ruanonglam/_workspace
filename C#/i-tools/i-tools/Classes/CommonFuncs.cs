using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace i_tools.Classes
{
    class CommonFuncs
    {
        public static void initControl()
        {
            CommonVals.HomeScreen = new HomeScreen();
            CommonVals.WorkScreen = new WorkScreen();
            CommonVals.FilenFolderScreen = new FilenFolderScreen();
            CommonVals.SecutrityScreen = new SecutrityScreen();
            CommonVals.IToolScreen = new IToolScreen();
            CommonVals.InternetScreen = new InternetScreen();
            CommonVals.FavoriteScreen = new FavoriteScreen();
            CommonVals.SettingScreen = new SettingScreen();
        }

        public static void displayScreen(UserControl screen)
        {
            if (screen != CommonVals.CurrentScreen)
            {
                CommonVals.MainPanel.Controls.Clear();
                CommonVals.MainPanel.Controls.Add(screen);
                CommonVals.CurrentScreen = screen;
            }
        }

        public static void displayHomeScreen()
        {
            CommonVals.MainPanel.Controls.Clear();
            CommonVals.MainPanel.Controls.Add(CommonVals.HomeScreen);
            CommonVals.CurrentScreen = CommonVals.HomeScreen;
            CommonVals.BackButton.Visible = false;
        }

        public static void displayScreen(string screenID)
        {
            switch (screenID)
            {
                case Constants.DIS_DETAIL_WORK_FJN:
                    displayScreen(CommonVals.WorkScreen);
                    break;
                case Constants.DIS_DETAIL_FILE_FOLDER:
                    displayScreen(CommonVals.FilenFolderScreen);
                    break;
                case Constants.DIS_DETAIL_SECURITY:
                    displayScreen(CommonVals.SecutrityScreen);
                    break;
                case Constants.DIS_DETAIL_I_TOOL:
                    displayScreen(CommonVals.IToolScreen);
                    break;
                case Constants.DIS_DETAIL_INTERNET:
                    displayScreen(CommonVals.InternetScreen);
                    break;
                case Constants.DIS_DETAIL_FAVORITE:
                    displayScreen(CommonVals.FavoriteScreen);
                    break;
            }
        }
    }
}
