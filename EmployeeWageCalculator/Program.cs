using System.Security.Cryptography;

namespace EmployeeWageCalculator;

internal class Program
{
    const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
    const int RATE_PER_HOUR = 20;
    const int MAX_WORKING_DAYS = 20, MAX_WORKING_HOURS = 100;
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to employee wage calculator...!!!");
        CalculateWage();
    }
    static int GetAttendance()
    {
         int empHours;
         Random random = new();
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
         return empHours;
    }
    static void CalculateWage()
    {
        int totalEmpHours = 0, totalEmpWage = 0, totalWorkingDays = 0;
        while (totalEmpHours < MAX_WORKING_HOURS && totalWorkingDays < MAX_WORKING_DAYS)
        {
            totalWorkingDays++;
            int empHours = GetAttendance();
            int empWage = empHours * RATE_PER_HOUR;
            totalEmpWage += empWage;
            Console.WriteLine($"Employee earned for day {totalWorkingDays} : {empWage}");
            totalEmpHours += empHours;
        }
        Console.WriteLine("Employee earned in a month: " + totalEmpWage + '\n' + $"Employee worked for " +
            $"{totalEmpHours} hours in month " + '\n' + $"Employee worked for {totalWorkingDays} days");
    }
}