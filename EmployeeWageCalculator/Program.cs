using System.Security.Cryptography;

namespace EmployeeWageCalculator
{
    internal class Program
    {
        const int IS_PRESENT = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage calculator...!!!");
            getAttendance();
        }
        static void getAttendance()
        {
            Random random = new Random();
            if (random.Next(2) == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}