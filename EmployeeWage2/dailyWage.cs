using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public  class dailyWage
    {
        public  void  dailyWageCalculater() 
        { 
           int isfulltime = 0;
           
            int employeerateperhour = 20;
            int employeehours;
            int employeewage;
            Random random = new Random();

            int check = random.Next(0, 2);

            if (check == isfulltime){
                employeehours = 8;
            }
            else
            {
                employeehours = 4;
            }

            employeewage = employeehours*employeerateperhour;
            Console.WriteLine("Emp wage :" +  employeewage);
        }
    }
}
