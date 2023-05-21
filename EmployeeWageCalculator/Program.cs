using System.Security.Cryptography;

namespace EmployeeWageCalculator
{
    internal class Program
    {
        const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
        const int RATE_PER_HOUR = 20;
        int empHours;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage calculator...!!!");
            Program program = new Program();
            program.getAttendance();
        }
        void getAttendance()
        {
            int totalEmpHours = 0;
            for (int i = 1; i <= 20; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHours += empHours;
            }
            int empMonthlyWage = totalEmpHours * RATE_PER_HOUR;
            Console.WriteLine("Employee earned in a month: " + empMonthlyWage);
        }
    }
}