using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Homework
{
    class Employee
    {
        /// <summary>
        /// init property
        /// </summary>
        public readonly uint ID;
        private static uint Counter;
        private String name;
        private String surname;
        private ushort salary;

        /// <summary>
        /// full-property
        /// </summary>
        public String Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value != null)
                {
                    this.name = value;
                }
                else
                {
                    var ex = new EmployeeException("Error with name!\n" +
                        "Example :  Vadim, Andrey,Alex...");
                    ex.HelpLink = "https://www.quora.com/" +
                        "What-is-the-correct-format-to-write-my-name";
                }
            }
        }
        public String Surname
        {
            get => surname;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value != null)
                {
                    this.surname = value;
                }
                else
                {
                    var ex = new EmployeeException("Error with surname!\n" +
                        "Example : Chorrny, Mask, Bezos...");
                    ex.HelpLink = "https://english.stackexchange.com/" +
                        "questions/272583/how-to-write-my-name";
                }
            }
        }
        public ushort Salary
        {
            get => salary;
            set
            {
                if (value > 0 && value < 20000)
                {
                    this.salary = value;
                }
                else
                {
                    var ex = new EmployeeException($"Error with salary!\n" +
                        "Example : 1000,2000,1300,4800\n");
                    ex.HelpLink = "https://www.thebalancecareers.com/" +
                        "when-and-how-to-disclose-your-salary-requirements-2058756";
                }
            }
        }

        /// <summary>
        /// ctor
        /// </summary>
        static Employee() // for random
        {
            Counter = 0;
            //Counter = (uint)new Random().Next(1000-2000);
        }
        public Employee(string name,string surname,ushort salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;
            ID = ++Counter;
        }
        /// <summary>
        /// output property
        /// </summary>
        public override string ToString()
        {
            return $"ID {ID}\n" +
                $"Name {Name}\n" +
                $"Surname {Surname}\n" +
                $"Salary {Salary}\n";
        }

        // Methods

        public void AddSalary(ushort salary)
        {
            if (salary > 0)
            {
                checked
                {
                    this.Salary += salary;
                }
            }
            else
            {
                throw new EmployeeException("Error with add salary!");
            }
        }
        public void RemoveSalary(ushort salary)
        {
            if (salary > 0)
            {
                checked
                {
                    this.Salary -= salary;
                }
            }
            else
            {
                throw new EmployeeException("Error with add salary!");
            }
        }






    }
}
