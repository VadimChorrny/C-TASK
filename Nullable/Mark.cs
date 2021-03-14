using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class Mark
    {
        private DateTime Time = new DateTime();
        public Nullable<int> Marks { get; set; }
        public String NameLesson { get; set; }
        public int? NumberLesson { get; set; }
        public Mark(String name,int? number,DateTime time, int? marks)
        {
            this.Time = time;
            this.Marks = marks;
            this.NumberLesson = number;
            this.NameLesson = name;
        }
        public override string ToString() => $"Ball\nNumber lesson - {NumberLesson}\n" +
            $"Lesson - {NameLesson}\n" +
            $"Time - {Time}," +
            $"\nMark - {Marks}";
    }
}
