using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class Student
    {
        public string Name { get; set; }
        List<Mark> marks = new List<Mark>();
        public void AddMark(Mark mark)
        {
            marks.Add(mark);
        }

}
