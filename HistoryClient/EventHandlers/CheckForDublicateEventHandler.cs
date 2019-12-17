using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryClient
{
    class CheckForDublicateEventHandler
    {
        public static void CheckIfDublicate(object sender, EventArgs e)
        {
            Info info = new Info(1);
            Info lastInfo = info[Info.index - 2];
            //sender
            //LoadingScreen ls = (LoadingScreen)sender;

            if (info[Info.index - 1].Equals(lastInfo))
            {
                MessageBox.Show("Event already uploaded");
            }
        }
    }
}
