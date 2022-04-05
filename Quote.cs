using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_10_Question_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Quotes";
            string quote;
            char colour;
            int count = 1;
            while (count <= 3) // loop must run 3 times
            {
                Console.Write("Please enter your favourite quote: ");
                quote = Console.ReadLine();
                Console.WriteLine("In which colour would you like to display your quote?");
                Console.WriteLine("G) Green");
                Console.WriteLine("P) Purple");
                Console.WriteLine("R) Red");
                Console.WriteLine("Y) Yellow");
                Console.Write("Please enter your choice (G, P, R, or Y): ");
                colour = char.Parse(Console.ReadLine());
                DisplayQuote(colour, quote);
                count ++;
            }// the error is in the loop in static void Main
        }
        static void DisplayQuote(char colour, string quote)
        {
            // code is correct in this method, so do not change the code!
            if (colour == 'G' || colour == 'g')
                Console.ForegroundColor = ConsoleColor.Green; //changes colour to green
            else if (colour == 'P' || colour == 'p')
                Console.ForegroundColor = ConsoleColor.Magenta; //changes colour to magenta
            else if (colour == 'R' || colour == 'r')
                Console.ForegroundColor = ConsoleColor.Red; //changes colour to red
            else if (colour == 'Y' || colour == 'y')
                Console.ForegroundColor = ConsoleColor.Yellow; //changes colour to yellow
            else
                Console.ForegroundColor = ConsoleColor.White; //changes colour to white
            Console.WriteLine(quote);
            Console.ResetColor(); // resets colour to the default colour
            Console.ReadLine();
        }
    }
} 
