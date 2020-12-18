using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PartTimeEmployee
    {
        private static bool color;

        class Employee : PartTimeEmployee
        {
            private string HourlyRatee; // decimal

            public string HoursWorkedd  // property
            {
                get { return HourlyRatee; }   // get method
                set { HoursWorkedd = value; }  // set method
            }
        
        public static int HourlyRate { get; private set; }
            public static int HoursWorked { get; private set; }
            

            //PartTimeEmployee objects

            string color = "blue";
            static void Main(string[] args)
            {
                PartTimeEmployee timeEmployee = new PartTimeEmployee ();

                Console.WriteLine(PartTimeEmployee.color);

            }

            //Calculate Monthly Pay


            static void Main()
            {

                HourlyRate = 15;
                HoursWorked = 10;
                //Hourly Rate by Hours Worked

                Console.WriteLine(HourlyRate * HoursWorked);
                
            }
        }
    }
}
        

