using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Mark mark = new Mark("Math",3,new DateTime(2021,03,11),12);
            Student student = new Student();
            Console.WriteLine(mark);
            Console.WriteLine("____________");
            student.AddMark(mark);
            student.AddMark(new Mark("Ukrainial Languagge",4,new DateTime(2021, 02, 21), 8));
            student.AddMark(new Mark("PE",5,new DateTime(2020, 07, 12), 10));
            student.Render();
            Console.WriteLine("------------");
            student.RemoveMark(mark);
            student.Render();
            Console.WriteLine("---AVERAGE---");
            Console.WriteLine(student);

            
        }
    }
}
