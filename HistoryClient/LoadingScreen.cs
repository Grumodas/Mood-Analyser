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
        TaskCompletionSource<bool> tcs;

        public LoadingScreen()
        {
            th1 = new Thread(Run);
            lb = new Pages.LoadingBox();
            tcs = new TaskCompletionSource<bool>();
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
            tcs.TrySetResult(true);
        }

        private void Run()
        {
            
            lb.Show();

            if (Info.index > 1)
            {
                if (lastInfo.emotion.HasFlag(Emotion.HAPPY)) {
                    lb.SetMessage("Last time you were happy. Keep it up!");
                    lb.Update();
                    Thread.Sleep(3000);
                } else if(lastInfo.emotion.HasFlag(Emotion.SAD))
                {
                    lb.SetMessage("You were awfully sad earlier. Chear up!");
                    lb.Update();
                    Thread.Sleep(3000);
                }
                else if (lastInfo.emotion.HasFlag(Emotion.ANGRY))
                {
                    lb.SetMessage("In you last photo you were angry. We hope your good now.");
                    lb.Update();
                    Thread.Sleep(3000);
                }
                else if (lastInfo.emotion.HasFlag(Emotion.CONFUSED))
                {
                    lb.SetMessage("Something had confused you last time? Hope you figured it out!");
                    lb.Update();
                    Thread.Sleep(3000);
                }
                else if (lastInfo.emotion.HasFlag(Emotion.DISGUSTED))
                {
                    lb.SetMessage("You were disgusted by something. Stay cool.");
                    lb.Update();
                    Thread.Sleep(3000);
                }
                else if (lastInfo.emotion.HasFlag(Emotion.SURPRISED))
                {
                    lb.SetMessage("Something got you earlier? Nice! Right?");
                    lb.Update();
                    Thread.Sleep(3000);
                }
                else if (lastInfo.emotion.HasFlag(Emotion.CALM))
                {
                    lb.SetMessage("You were calm in your last photo. We are happy for you.");
                    lb.Update();
                    Thread.Sleep(3000);
                }
                else if (lastInfo.emotion.HasFlag(Emotion.FEAR))
                {
                    lb.SetMessage("Ghosts haunt your past? Worry not. It'll be all over soon...");
                    lb.Update();
                    Thread.Sleep(3000);
                }
                else
                {
                    lb.SetMessage("What a great day!");
                    lb.Update();
                    Thread.Sleep(3000);
                }
            }
            else
            {
                lb.SetMessage("What a great day!");
                lb.Update();
                Thread.Sleep(3000);
            }

            var a = tcs.Task.Result;
            lb.Hide();
            lb.SetMessage("It seems that today you are " + e.Replace(","," and ").ToLower());
            lb.HideLoadText();
            lb.Update();

            lb.ShowDialog();
        }
    }
}
