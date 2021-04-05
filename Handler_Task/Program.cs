using System;

namespace Handler_Task
{
    class Program
    {
        
        static void Main(string[] args)
        {
            HourMan hourMan = new HourMan();
            Watch watch = new Watch() { Hour = 10, Minute = 60 };
            Console.WriteLine(watch);
            watch.timer += hourMan.Handler;

            watch.Tick();
            //watch.Tick();
        }
    }
}
