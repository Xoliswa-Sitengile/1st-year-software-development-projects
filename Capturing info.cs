using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capturing_information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skater Results - Qualifying Competion";
            int count, numberOfSkaters = 0, failedToQualify = 0, qualify = 0, favouritesToWin = 0;
            string message = "NAME\t\tRATING\t\tRESULTS\t\t\n======\t=======\t======\n", skaterResults = " ", skaterName = " ";
            double skaterRating = 0, total = 0, min = 0, previousNumber = 0, max = 0, lowestRating = 100, highestRating = 0, competionAverage = 0;

            Console.Write("Please enter the number of skaters in the competition: ");
            numberOfSkaters = int.Parse(Console.ReadLine());
            Console.Clear();
            for (count = 1; count <= numberOfSkaters; count++)
            {
                Console.Write("Please enter the name of skater {0}: ", count);
                skaterName = Console.ReadLine();
                Console.Write("Please enter the rating for {0}: ", skaterName);
                skaterRating = double.Parse(Console.ReadLine());
                Console.ReadLine();
                if (skaterRating < previousNumber)
                {
                    min = Math.Min(skaterRating, Math.Min(previousNumber, lowestRating));
                    lowestRating = min;
                    previousNumber = lowestRating;
                }
                else if (skaterRating > previousNumber)
                {
                    max = Math.Max(previousNumber, Math.Max(skaterRating, highestRating));
                    highestRating = max;
                    previousNumber = highestRating;
                }
                if (skaterRating < 5)
                {
                    failedToQualify++;
                    skaterResults = "Failed to qualify";
                }
                else if (skaterRating >= 5 && skaterRating <= 7)
                {
                    qualify++;
                    skaterResults = "Quality";
                }
                else
                {
                    favouritesToWin++;
                    skaterResults = "Qualify: Favourite to win";
                }


                total = skaterRating + total;
                message = message + skaterName + "\t\t" + skaterRating + "\t" + skaterResults + "\n";
            }

            competionAverage = total / numberOfSkaters;
            message = message + "\n\n" + "Number of Skaters:\t" + numberOfSkaters + "\n" + "Failed to qualify:\t\t" + failedToQualify + "\n" + "Qualify:\t\t\t" + qualify + "\n" + "Qualify: Favourite to Win:\t" + favouritesToWin + "\n\n" + "Lowest rating:\t\t" + lowestRating + "\n" + "Highest rating: \t\t" + highestRating + "\n\n" + "Competition average:\t" + competionAverage.ToString("f2");
            MessageBox.Show(message, "Summary details for" + numberOfSkaters + "skaters", MessageBoxButtons.OK);

            Console.ReadLine();
        }
    }
}
