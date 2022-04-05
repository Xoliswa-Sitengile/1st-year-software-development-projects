using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac9Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, answer;
            string message;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            answer = number % 2; //determines remainder
            if (answer == 0) // if remainder == zero               
               message="Even number";
            else
              message= "Odd number";
            DisplayLine(message);
        }
        static void DisplayLine(string message)
        {
            Console.WriteLine("{0}", message);
            Console.ReadLine();
        }
    }
}
