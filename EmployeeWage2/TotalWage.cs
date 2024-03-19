using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public class TotalWage
    {
        public string company;
        public int empRateperhour;
        public int numOfWorkingDays;
        public int workingHour;
        public int totalWorker;
        public int totalWage=0;

        public TotalWage(string company , int empRateperhour , int numOfWorkingDays,  int totalWorker)
        {
            this.company = company;
            this.empRateperhour = empRateperhour;
            this.numOfWorkingDays = numOfWorkingDays;
            
            this.totalWorker = totalWorker;
        }
      public void computeWage()  {
            int i = 0;
            int partimeCount=0;
            int fulltimeCount = 0;
            Random random = new Random();
          while(i<totalWorker)
            {
                int typeWorker=random.Next(0,2);
                switch(typeWorker)
                {
                    case 0:
                        partimeCount++;
                        workingHour = 4;

                        break;
                    case 1:
                        fulltimeCount++;
                        workingHour=8;
                        break;
                      

                }


            }
            int workingday = 0;
          while ( workingday< numOfWorkingDays)
            {
                workingday++;
                totalWage = totalWage + (partimeCount * 4 * 20)+(fulltimeCount*8*20);
            }

            Console.WriteLine("total wage  is :" + totalWage);

        }
    }
}
