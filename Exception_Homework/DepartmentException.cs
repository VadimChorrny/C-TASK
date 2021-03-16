using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Homework
{
    class DepartmentException : ApplicationException
    {
        public DepartmentException(String message)
            : base(message) { }
    }
}
