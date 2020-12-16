using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Student(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
       
        }

        public override string ToString()
        {
            { 
                return string.Format($"{LastName}, {FirstName}");
                }
        }
    }
}
