using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public  class Attendence
    {
        public  void attendenceGiver() {
            int isfulltime = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 0)
            {
                Console.WriteLine("Employee is present "); 

            }
            else
            {
                Console.WriteLine("Employee is absent ");

            }

                }
    }
}
