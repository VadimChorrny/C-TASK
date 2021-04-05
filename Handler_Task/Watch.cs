using System;
using System.Collections.Generic;
using System.Text;

namespace Handler_Task
{
    class MyArgs : EventArgs
    {
        public byte Hour { get; set; }
        public byte Minute { get; set; }
        public MyArgs(byte hour, byte minute)
        {
            Hour = hour;
            Minute = minute;
        }
    }

    class Watch
    {
        public event EventHandler<MyArgs> timer;
        private byte hour;
        private byte minute;
        public byte Hour
        {
            get => hour;
            set
            {

                if (value >= 24)
                {
                    hour = 0;
                }
                hour = value;
            }
        }
        public bool isAlarm = false;
        public byte Minute

        {
            get => minute;
            set
            {
                minute = value;
                if (value <= 59)
                {
                    Console.WriteLine("Minute update!");
                }
                else if(value >= 59)
                {
                    minute = 0;
                    Hour++;
                }

            }
        }

        public virtual void OnTimer(MyArgs e) => timer?.Invoke(this,e);

        public void Tick()
        {
            if(!isAlarm)
            {
                Minute += 1;
                isAlarm = true;
                OnTimer(new MyArgs(Hour, Minute));
                Console.WriteLine("Спрацював будильник!");
            }
            else
            {
                Console.WriteLine("Будильник вже був спрацьований!");
            }
        }


        public override string ToString()
        {
            return $"Hour - {Hour}\n" +
                $"Minute - {Minute}";
        }
    }
    class HourMan
    {
        public void Handler(object sender, EventArgs args)
        {
            Watch watch = (Watch)sender;
            Console.WriteLine($"Hour {watch.Hour},Minute {watch.Minute},State timer {watch.isAlarm}");
        }
    }
}
