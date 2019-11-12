using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace Client
namespace HistoryClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //if the database is empty, allow to choose reference photo
            Application.Run(new UploadReferencePhoto());
            //else show regular menu
        }
    }
}
