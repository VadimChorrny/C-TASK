using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Homework
{
    class EmployeeException : ApplicationException
    {
        public EmployeeException(String message) : base(message) { }
    }
}
