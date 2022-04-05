using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//declare varriables
                string employeeName;
                double normalPay, overTimePay, totalPay;
                double totalNumbersOfHoursWorked, overTimeHoursWorked, employeeHourlyRate, normalHoursWorked;
                //accept user input (promt and get)
                Console.Write("Please Enter the employee's name: ");
                employeeName = Console.ReadLine();
                Console.Write("Please enter the employee's hourly rate: ");
                employeeHourlyRate = double.Parse(Console.ReadLine());
                Console.Write("Please enter the number of normal hours work: ");
                normalHoursWorked = double.Parse(Console.ReadLine());
                Console.Write("Please enter the number of overtime hours worked: ");
                overTimeHoursWorked = double.Parse(Console.ReadLine());
                Console.WriteLine("Payslip for:{0}", employeeName);
                //calculate
                totalNumbersOfHoursWorked = normalHoursWorked + overTimeHoursWorked;
                normalPay = normalHoursWorked * employeeHourlyRate;
                overTimePay = overTimeHoursWorked * (employeeHourlyRate * 1.5);
                totalPay = normalPay + overTimePay;
                //display output
                Console.WriteLine("Normal Hours worked:{0}", normalHoursWorked);
                Console.WriteLine("Overtime Hours worked:{0}", overTimeHoursWorked);
                Console.WriteLine("Total Hours worked:{0}", totalNumbersOfHoursWorked);
                Console.WriteLine();
                Console.WriteLine("Normal Pay:      {0:c}", normalPay);
                Console.WriteLine("Overtime Pay:    {0:c}", overTimePay);
                Console.WriteLine("Total Pay:       {0:c}", totalPay);
                Console.ReadLine();


            }
        }
    }
}
