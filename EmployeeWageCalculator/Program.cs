using System.Security.Cryptography;

namespace EmployeeWageCalculator
{
    internal class Program
    {
        const int IS_PRESENT = 1;
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
            if (random.Next(2) == IS_PRESENT)
            {
                empHours = 8;
            }
            else
            {
                empHours = 0;
            }
        }
        void getDailyWage()
        {
            int dailyWage = empHours * RATE_PER_HOUR;
            Console.WriteLine("Employee earned today : " + dailyWage);
        }
    }
}