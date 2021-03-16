using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Homework
{
    class Department
    {
        List<Employee> department;
        public Department() //
        {
            department = new List<Employee>();
        }
        public void AddEmployeer(Employee employee)
        {
            if(employee != null)
            {
                checked
                {
                    department.Add(employee);
                }
            }
            else
            {
                throw new DepartmentException("Error with add employee!");
            }
        }
        public void RemoveEmployee(Employee employee)
        {
            if(employee != null)
            {
                checked
                {
                    department.Remove(employee);
                }
            }
            else
            {
                throw new DepartmentException("Error with remove employee!");
            }
        }
        public void Render()
        {
            foreach (var item in department)
            {
                Console.WriteLine(item);
            }
        }
    }
}