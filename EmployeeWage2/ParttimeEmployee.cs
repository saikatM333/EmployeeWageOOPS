using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public  class ParttimeEmployee
    {
        public void PartimeEmployeeWage()

        {
            int isparttime = 0;
            int isfulltime = 1;
            int employeerateperhour = 20;
            int employeeWorkinghour;
            int employeeWage;
            Random random = new Random();
            int employeecheck = random.Next(0,2);

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

            employeeWage = employeeWorkinghour * employeerateperhour;
            Console.WriteLine("Employee wage  is :" + employeeWage);


        }
    }
}
