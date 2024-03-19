using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public  class MounthlyWage
    {
       public void MounthlyWageCalculater () {

            int isparttime = 0;
            int isfulltime = 1;
            int employeerateperhour = 20;
            int employeeWorkinghour;
            int employeeWage = 0;
            int totalDay = 15;

            Random random = new Random();
            int employeecheck = random.Next(0, 2);

            if (employeecheck == isparttime)
            {
                employeeWorkinghour = 4;
            }
            else if (employeecheck == isfulltime)
            {
                employeeWorkinghour = 8;
            }
            else
            {
                employeeWorkinghour = 0;
            }
            int day = 0;
            while (day < totalDay)
            {
                employeeWage = employeeWage + (employeeWorkinghour *employeerateperhour);
            }

            Console.WriteLine("Employee wage  is :" + employeeWage);

        }
    }
}
