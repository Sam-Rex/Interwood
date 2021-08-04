using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM_stores.Ul.Shared
{
    class prepViews
    {
        private static Form taView;
        private static Form nullableView;

        static void Viewer_Close(object sender, FormClosedEventArgs e)
        {
            taView = null;
        }

        /// <summary>
        /// get the nullableView as a external Form to prepare it then return Form and give it an event to clean up any resources have been used
        /// </summary>
        /// <param name="nullableView"></param>
        /// <returns></returns>
        public static Form giView(Form nullableView)
        {
            taView = new Form();
                if (nullableView == null)
                {
                   // nullableView = new Form.taView();
                    nullableView.FormClosed += new FormClosedEventHandler(Viewer_Close);
                }
                return nullableView;
         
        }
        public static Form decorateView
        {
            get
            {
                if (nullableView == null)
                {
                    nullableView = new homeScreen();
                    nullableView.FormClosed += new FormClosedEventHandler(Viewer_Close);
                }
                return nullableView;
            }


        }
        public Form setView(Form mainView )
        {
            //_ctrlChannel.InitializeDb();
            if (nullableView == null) nullableView = mainView;
           // nullableView.mainNavigationMenu.Enabled = false;
            nullableView.Show();
            return mainView;
            // bringCust brcust = new bringCust();brcust.ShowDialog();

        }

    }
}
