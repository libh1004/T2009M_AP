using System;
using T2009M_AP.session1;

namespace T2009M_AP.session4
{
    public class DemoDelegate
    {

        // khai bao even
        public event ShowString ShowEvent;
        public DemoDelegate()
        {
            //Program.ss += ShowMsg;
            //Program.ss += SayHello;
        }

        public void SayHello(string s)
        {
            Console.WriteLine("Hello: " + s);
        }
        public static void ShowMsg(string msg) // ham tra ve void va tham so la 1 string
        {
            Console.WriteLine("Show msg: "+msg);
        }

        public void ShowInfo(string info) // ham tra ve void va tham so la 1 string
        {
            Console.WriteLine("Info: "+info);
        }

        public void Running()
        {
            if (ShowEvent == null)
            {
                ShowEvent += ShowMsg;
                ShowEvent += ShowInfo;
            }

            ShowEvent("Toi vua phat ra 1 su kien");
        }
    }
}