using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Employee
    {
        public string FirstName { get; set; }

        public string SurName { get; set; }
        public static int Salary { get; private set; }

        private static int b;

        private string Salaryy; // decimal

       
    



    public Employee(string firstname, string surname)
        {
            FirstName = firstname;
            SurName = surname;
       
        }

       

        public override string ToString()
        {
            { 
                return string.Format($"{SurName}, {FirstName}");
                }
        }
    }
}
