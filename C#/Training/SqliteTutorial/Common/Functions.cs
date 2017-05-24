using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqliteTutorial.Common
{
    class Functions
    {

        public static void InitForm() {
            Common.DataLoaded.HomeScreen = new HomeScreen();
            Common.DataLoaded.PartIScreen = new PartIScreen();
            Common.DataLoaded.PartIDetailScreen = new Screens.PartI.PartIDetailScreen();
        }

        public static void SetScreen(UserControl screen)
        {
            Common.DataLoaded.MainPanel.Controls.Clear();
            Common.DataLoaded.MainPanel.Controls.Add(screen);
        }

        public static void getPage(int action) {
            if (action == Common.Constants.VIEW_NEXT)
            {
                if (Common.DataLoaded.CurrentPage == Common.DataLoaded.TotalPages)
                {
                    Common.DataLoaded.CurrentPage = 1;
                }
                else {
                    Common.DataLoaded.CurrentPage += 1;
                }
            }
            else {
                if (Common.DataLoaded.CurrentPage - 1 == 0)
                {
                    Common.DataLoaded.CurrentPage = Common.DataLoaded.TotalPages;

                }
                else {
                    Common.DataLoaded.CurrentPage -= 1;
                }
                
            }
        }

        public static String getImageFileName() {
            return Common.DataLoaded.CurrentPage + ".jpg";
        }
    }
}
