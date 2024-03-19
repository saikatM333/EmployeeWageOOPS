using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public class multipleWage
    {
        public void computeMultipleCompanyWage( string company , int empRatePerHour, int numOfWorkingDays, int MaxHoursPerMounth)
        {
            int employeeWorkinghour = 0, totalEmployeeHrs  = 0 , totalWorking=0;

            while (totalEmpHrs<=MaxHoursPerMounth) {
                totalWorking++;
                Random random = new Random();
                int employeecheck = random.Next(0, 2);
                switch (employeecheck)
                {
                    case 0:
                        employeeWorkinghour = 4;
                        break;
                    case 1:
                        employeeWorkinghour = 8;
                        break;
                    default:
                        employeeWorkinghour = 0;
                        break;

                }
                totalEmployeeHrs += employeeWorkinghour;

            }
            int totalEmployeeWage = totalEmployeeHrs * empRatePerHour;

            Console.WriteLine("total wage  is :" + totalEmployeeWage);








        }
    }
}
