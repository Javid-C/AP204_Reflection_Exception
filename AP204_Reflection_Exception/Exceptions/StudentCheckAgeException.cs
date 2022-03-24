using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Reflection_Exception.Exceptions
{
    class StudentCheckAgeException:Exception
    {
        private string _message;
        public override string Message => _message;


        public StudentCheckAgeException(string message= "Telebenin yashi universitet ucun uygun deyil")
        {
            _message = message;
        }
    }
}
