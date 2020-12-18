using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class FullTimeEmployee
    {
       
            class Employee : FullTimeEmployee
        {
            public string FirstName { get; set; }

            public string SurName { get; set; }
            public static int Salary { get; private set; }

            private static int b;


            private string Salaryy; // decimal

            public string Sal  // property
            {
                get { return Salaryy; }   // get method
                set { Salaryy = value; }  // set method
            }

            //FullTimeEmployee objects

            string color = "red";
            static void Main(string[] args)
            {
                Employee employee = new Employee();

                Console.WriteLine(employee.color);

            }

            static void Main()
            {
                //Monthly Pay is got by dividing salary by 12

                Salary = 0;
                b = 12;

                Console.WriteLine(Salary / b);
            }
        }
    }
}
