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
            program.getDailyWage();
        }
        void getAttendance()
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
        }
        void getDailyWage()
        {
            int dailyWage = empHours * RATE_PER_HOUR;
            Console.WriteLine("Employee earned today : " + dailyWage);
        }
    }
}