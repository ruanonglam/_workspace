using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace i_tools.Classes
{
    class CommonVals
    {
        #region Log
        public static StringBuilder LOG = new StringBuilder(1024);
        #endregion

        #region Controls
        public static HomeScreen HomeScreen = null;
        public static WorkScreen WorkScreen = null;
        public static FilenFolderScreen FilenFolderScreen = null;
        public static SecutrityScreen SecutrityScreen = null;
        public static IToolScreen IToolScreen = null;
        public static InternetScreen InternetScreen = null;
        public static FavoriteScreen FavoriteScreen = null;
        public static SettingScreen SettingScreen = null;
        public static MessageBox MessageBox = new MessageBox();
        #endregion

        #region HomeScreen
        public static Panel MainPanel = null;
        public static PictureBox BackButton = null;
        #endregion

        public static UserControl CurrentScreen = null;
    }
}
