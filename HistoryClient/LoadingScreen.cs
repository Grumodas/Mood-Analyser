using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryClient
{
    class LoadingScreen
    {
        Thread th1;
        string e = " ";
        Pages.LoadingBox lb;
        Info lastInfo;

        public LoadingScreen()
        {
            th1 = new Thread(Run);
            lb = new Pages.LoadingBox();
            if (Info.index > 1)
                lastInfo = Info.InfoList[Info.index - 2];
        }

        // Dependency Injection
        public LoadingScreen(Info mockInfo)
        {
            th1 = new Thread(Run);
            lb = new Pages.LoadingBox();
            lastInfo = mockInfo;
            Info.index = 2;
        }

        public void Open()
        {
            

            th1.Start();
        }

        public void WaitForClose()
        {
            th1.Join();
        }

        public void setEmotions(string e)
        {
            this.e = e;
        }

        private void Run()
        {
            
            lb.Show();

            //if (Info.index > 1)
            //{
            //    //turn enum to stirng
            //    lb.SetMessage("Last time you were: " + lastInfo.emotion);
            //    lb.Update();
            //    Thread.Sleep(3000);
            //} else
            //{
                lb.SetMessage("Today's Lucky number is: 42");
                lb.Update();
                Thread.Sleep(3000);
            //}

            for (int i = 0; i < 10; i++)
            {
                if (e != " ")
                {
                    lb.Hide();
                    lb.SetMessage("It seems that you are: " + e);
                    lb.Update();
                    break;
                }
                Thread.Sleep(1000);
            }

            lb.ShowDialog();
        }
    }
}
