using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Nullable
{
    class Student
    {
        public string Name { get; set; }
        List<Mark> marks;
        public Student()
        {
            marks = new List<Mark>();
        }
        public void AddMark(Mark @mark)
        {
            marks.Add(@mark);
        }
        public void RemoveMark(Mark @mark)
        {
            marks.Remove(@mark);
        }

        public int Average()
        {
            return (marks.Sum(e => Convert.ToInt32(e.Marks)) / marks.Count);
        }

        public override string ToString()
        {
            return $"{Average()}";
        }


        public void Render()
        {
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
