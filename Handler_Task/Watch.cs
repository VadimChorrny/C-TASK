using System;
using System.Collections.Generic;
using System.Text;

namespace Handler_Task
{
    class Watch
    {
        public event EventHandler<EventArgs> timer;
        public byte Hour
        {
            get => Hour;
            set
            {
                Hour = value;
                if (value <= 24 && value > 0)
                {
                    timer?.Invoke($"Timer update {this}", EventArgs.Empty);
                }
                else
                {
                    timer?.Invoke($"Error with time,you enter {this}", EventArgs.Empty);
                }
            }
        }
        public byte Minute
        {
            get => Minute;
            set
            {
                Minute = value;
                if (value < 60 && value > 0)
                {
                    Tick();
                    timer?.Invoke($"You update minute {this}", EventArgs.Empty);
                }
                else if(value >= 60)
                {
                    Hour++;
                    timer?.Invoke($"Задзвонив будильник!\n{this}", EventArgs.Empty);
                }
            }
        }
        public Watch(byte hour,byte minute)
        {
            this.Hour = hour;
            this.Minute = minute;
        }

        public void Tick()
        {
            this.Minute += 1;
        }

    }
}
