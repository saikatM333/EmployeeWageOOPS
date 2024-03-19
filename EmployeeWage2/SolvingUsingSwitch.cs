using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public  class SolvingUsingSwitch
    {
        public void switchImplementing()
        {
            int isparttime = 0;
            int isfulltime = 1;
            int employeerateperhour = 20;
            int employeeWorkinghour;
            int employeeWage;
            Random random = new Random();
            int employeecheck = random.Next(0, 2);
            switch(employeecheck)
            {
                case 0:
                    employeeWorkinghour=4;
                    break;
                case 1:
                    employeeWorkinghour=8;
                    break;
                default:
                    employeeWorkinghour = 0;
                    break;

            }
            employeeWage = employeeWorkinghour * employeerateperhour;
            Console.WriteLine("Employee wage  is :" + employeeWage);




        }
    }
}
