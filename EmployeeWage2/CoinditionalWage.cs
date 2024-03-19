using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public  class CoinditionalWage
    {
        public  void  CoinditionalWageCalculator() 
        {
            int isparttime = 0;
            int isfulltime = 1;
            int employeerateperhour = 20;
            int employeeWorkinghour;
            int employeeWage=0;
            int employeeWorkingday=20;
            int totalworkinghour;
            Random random = new Random();
            int employeecheck = random.Next(0, 2);
            switch (employeecheck)
            {
                case 0:
                    employeeWorkinghour = 4;
                    totalworkinghour=80;

                    break;
                case 1:
                    employeeWorkinghour = 8;
                    totalworkinghour = 160;
                    break;
                default:
                    employeeWorkinghour = 0;
                    totalworkinghour = 0;
                    break;

            }
            int workingHour=0;
            int workingday=0;

            while (employeeWorkingday >= workingday && totalworkinghour >= workingHour) ;
            {
                employeeWorkingday++;
                employeeWage = employeeWage + employeeWorkinghour * employeerateperhour;
                workingHour += workingHour;

            }

            Console.WriteLine("Employee wage  is :" + employeeWage);

        }
    }
}
