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
        private Thread th1;
        private Pages.LoadingBox lb;
        private readonly object eLock;
        //TaskCompletionSource<bool> tcs;
        private Info lastInfo;
        private string e = " ";
        

        public LoadingScreen()
        {
            th1 = new Thread(Run);
            eLock = new object();
            if (Info.index > 0)
                lastInfo = Info.InfoList[Info.index - 1];
        }

        // Dependency Injection
        public LoadingScreen(Info mockInfo)
        {
            th1 = new Thread(Run);
            eLock = new object();
            lastInfo = mockInfo;
            Info.index = 1;
        }

        public void Open()
        {
            th1.Start();
        }

        public void WaitForClose()
        {
            th1.Join();
        }

        private void setE(string e)
        {
            lock(eLock) {
                this.e = e;

            }
        }

        private string getE()
        {

            lock (eLock)
            {
                string eCopy = String.Copy(e);

                return eCopy;
            }
            
            // kreipimasis i musu web serivce pavyzdys
            //Returns "Hello, World"
            SimpleService.SimpleSoapClient client = new SimpleService.SimpleSoapClient();
            string justAHello = client.HelloWorld();
            string threadName = client.Mocking(5);
            
            
        }

        public void setEmotions(string e)
        {
            setE(e);
            //tcs.TrySetResult(true);
            lb.dots = false;
        }

        private void Run()
        {
            //tcs = new TaskCompletionSource<bool>();
            lb = new Pages.LoadingBox();
            lb.Show();

            if (Info.index > 0)
            {
                if (lastInfo.emotion.HasFlag(Emotion.HAPPY)) {
                    setE("Last time you were happy. Keep it up!");
                }
                else if (lastInfo.emotion.HasFlag(Emotion.SAD))
                {
                    setE("You were awfully sad earlier. Chear up!");
                }
                else if (lastInfo.emotion.HasFlag(Emotion.ANGRY))
                {
                    setE("In you last photo you were angry. We hope your good now.");
                }
                else if (lastInfo.emotion.HasFlag(Emotion.CONFUSED))
                {
                    setE("Something had confused you last time? Hope you figured it out!");
                }
                else if (lastInfo.emotion.HasFlag(Emotion.DISGUSTED))
                {
                    setE("You were disgusted by something. Stay cool.");
                }
                else if (lastInfo.emotion.HasFlag(Emotion.SURPRISED))
                {
                    setE("Something got you earlier? Nice! Right?");
                }
                else if (lastInfo.emotion.HasFlag(Emotion.CALM))
                {
                    setE("You were calm in your last photo. We are happy for you.");
                }
                else if (lastInfo.emotion.HasFlag(Emotion.FEAR))
                {
                    setE("Ghosts haunt your past? Worry not. It'll be all over soon...");
                }
                else
                {
                    setE("What a great day!");
                }
            }
            else
            {
                setE("What a great day!");
            }

            lb.SetMessage(getE());
            lb.Update();

            //var a = tcs.Task.Result;
            lb.RunLoadingDots();
            
            lb.SetMessage("It seems that today you are " + getE().Replace(",", " and ").ToLower());
            lb.HideLoadText();
            lb.Hide();
            lb.Update();
            Thread.Sleep(1000);
            lb.ShowDialog();
        }

    }
}
