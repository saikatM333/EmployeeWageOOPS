using EmployeeWage2;

public class Program
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("employee wages ");

        Console.WriteLine("press 0-7 to use diffrent functionality");

        int choice =Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 0: Console.WriteLine("attenddence of employee ");
                 Attendence attendence=  new Attendence();
                attendence.attendenceGiver();
                break;

                case 1: Console.WriteLine("calculate the daily wage ");
                  dailyWage wage = new dailyWage();
                wage.dailyWageCalculater();
                break;
                case 2: Console.WriteLine("calculate the wage for the part time employee  ");
                ParttimeEmployee parttimeEmployee = new ParttimeEmployee();
                parttimeEmployee.PartimeEmployeeWage();
                break;
                case 3: Console.WriteLine("calculate the wage based on the type of employment ");
                SolvingUsingSwitch solvingUsingSwitch = new SolvingUsingSwitch();
                solvingUsingSwitch.switchImplementing();
                break;
                case 4: Console.WriteLine("calculate the mounthly wage ");
                MounthlyWage  mounthly = new MounthlyWage();
                mounthly.MounthlyWageCalculater();
                break;
                case 5: Console.WriteLine("calculate the wage based on the number of hours workedor  number of days worked ");
                CoinditionalWage coinditionalWage = new CoinditionalWage();
                coinditionalWage.CoinditionalWageCalculator();
                break;
                case 6: Console.WriteLine("calculate the wage for the multiple companies ");
                multipleWage company = new multipleWage();
                company.computeMultipleCompanyWage("sai", 20, 20, 300);

                break;
                case 7: Console.WriteLine("calculate the total wage of the companies ");
                TotalWage totalWage = new TotalWage("sai", 20, 20, 300);
                totalWage.computeWage();
                break;
        }
    }
}