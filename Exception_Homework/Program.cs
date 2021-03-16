using System;

namespace Exception_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jeff", "Bezos", 1000);
            Department department = new Department();

            try
            {
                employee.AddSalary(4000);
                employee.RemoveSalary(1600);
                Console.WriteLine(employee);

                // department
                department.AddEmployeer(new Employee("Mark", "Zuckerberg", 2400));
                department.AddEmployeer(new Employee("Bill", "Gates", 1200));
                department.AddEmployeer(new Employee("Robert", "Martin", 11200));
                department.AddEmployeer(new Employee(null, null, 21000));
            }
            catch (DepartmentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.HelpLink);
            }
            catch (EmployeeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.HelpLink);
            }
            catch
            {

            }

        }
    }
}
