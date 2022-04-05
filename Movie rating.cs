using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parallel Arrays with Methods";
            String[] movie = {"Everybody's Fine","Crazy/Beautiful ","Angry Birds: The Movie", "The Green Hornet", "Ice Age: Continental", "Scooby-Doo: The Movie" };
            int[] rating = { 8, 6, 5, 6, 4, 6 };
            int[] category = { 2, 3, 6, 4, 6, 6 };
            String[] categoryName = { "","Comedy", "Drama", "Romance", "Action", "Sci-Fi", "Family" };
            int choice = DisplayMenu();
            while (choice != 13)
            {
                if (choice == 1)
                    DisplayOption1(category, movie, rating);
                else if (choice == 2)
                    DisplayOption2(category, movie, rating);
                else if (choice == 3)
                    DisplayOption3(movie, rating);
                else if (choice == 4)
                    DisplayOption4(movie, rating);
                else if (choice == 5)
                    DisplayOption5(movie, rating);
                else if (choice == 6)
                    DisplayOption6(category, movie, rating, categoryName);
                else if (choice == 7)
                    DisplayOption7(movie, rating);
                else if (choice == 8)
                    DisplayOption8(movie, rating);
                else if (choice == 9)
                    DisplayOption9(movie, rating, category);
                else if (choice == 10)
                    DisplayOption10(movie, rating);
                else if (choice == 11)
                    DisplayOption11(movie, rating);
                else if (choice == 12)
                    DisplayOption12(category, movie, rating, categoryName);
                choice = DisplayMenu();
            } // end loop
            Console.ReadLine();
        
        }
        static void DisplayOption1(int[] category, String[] movie, int[] rating)
        {
            int i = 0;
            Console.WriteLine("Category No.\tMovie\t\t\t\tRating");
            for (i = 0; i < category.Length; i++)// your code goes here
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", category [i],movie [i],rating[i]);
            }
            Console.ReadLine();
        }
        static void DisplayOption2(int[] category, String[] movie, int[] rating)
        {
            int i = 0;
            Console.WriteLine("Category No.\tMovie\t\t\t\tRating");
            for (i = category.Length -1; i >= 0; i--)// your code goes here
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", category[i], movie[i], rating[i]);
            }// your code goes here
            Console.ReadLine();
        }
        static void DisplayOption3(String[] movie, int[] rating)
        {
            int i = 0,sum = 0;
            double average = 0;
            Console.WriteLine("Movie\t\t\t\tRating");
           for(i = 0; i < movie.Length; i++) // your code goes here
           {
                Console.WriteLine("{0}\t\t{1}", movie [i], rating [i]);
                sum += rating[i];
           }
            Console.WriteLine();
            average = (double) sum / rating.Length;
            Console.WriteLine("Average Rating: {0:f}",average);
            Console.ReadLine();
        }
        static void DisplayOption4(String[] movie, int[] rating)
        {
            int i = 0, sum =0, count = 0;
            double average = 0;
            string message = "Movies above average rating\n\n";
            for ( i = 0; i < rating.Length;i++) // your code goes here
            {
                sum += rating[i];
            }
            average = (double)sum / rating.Length;
            for (i = 0;i < rating.Length;i++)
            {
                if (rating[i] > average)
                {
                    message += movie[i] + "\n";
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} movies are above the average rating of {1:f}", count, average);
            MessageBox.Show(message);
                Console.ReadLine();
        }
        static void DisplayOption5(string[] movie, int[] rating)
        {
            int i = 0, highest = 0;
            Console.WriteLine("Top Rating");
            Console.WriteLine();
            Console.WriteLine("Movie\t\t\t\tRating");
           //your code goes here
           for (i = 0; i < movie.Length;i++)
           {
                highest = Math.Max(highest, rating[i]);
           }
           for (i = 0; i < movie.Length;i++)
            {
                if(highest == rating[i])
                {
                    Console.Write("{0}\t\t{1}", movie[i], rating[i]);
                }
            }
            Console.ReadLine();
        }
        static void DisplayOption6(int[] category, String[] movie, int[] rating, String[]
        categoryName)
        {
            int i =0,lowest = 99999;
            Console.WriteLine("Lowest Rating");
            Console.WriteLine();
            Console.WriteLine("Movie\t\t\t\tRating\t\tCategory");
            for (i = 0; i < movie.Length; i++)
            {
                lowest = Math.Min(lowest, rating[i]);
            }
            for ( i = 0;i < movie.Length ;i++) // your code goes here
            {
                if (lowest == rating[i])
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", movie[i], rating[i], categoryName[category[i]]);
                }
               
            }
            Console.ReadLine();


        }
        static void DisplayOption7(String[] movie, int[] rating)
        {
            string movieName;
            int i = 0;
            bool found = false;
            Console.WriteLine();
            Console.Write("Enter movie name : "); // your code goes here
            movieName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Movie\t\t\t\tRating");
            for (i = 0; i < rating.Length; i++)
            {
                if (movie[i] == movieName)
                {
                    Console.WriteLine("{0}\t\t {1}", movie [i], rating [i]);
                    found = true;
                }
            }
            if ( found == false)
            {
                Console.WriteLine("Movie {0} not found", movieName);
            }
            Console.ReadLine();
        }
        static void DisplayOption8(String[] movie, int[] rating)
        {
            int sum = 0, i = 0;
            double average = 0;
            Console.WriteLine("Movie\t\t\t\tRating");
            for (i = 0; i < rating.Length; i++) // your code goes here
            {
                sum += rating[i];
            }
            average = (double)sum / rating.Length;
            for (i = 0; i < movie.Length;i++)
            {
                if (rating[i] > average)
                {
                    Console.WriteLine("{0}\t\t{1}+", movie[i], rating[i]);
                }
                else if (rating[i] < average)
                {
                    Console.WriteLine("{0}\t\t{1}-", movie[i], rating[i]);
                }
                else if(rating[i] == average)
                {
                    Console.WriteLine("{0}\t\t{1}=", movie[i], rating[i]);
                }
            }

            Console.ReadLine();
        }
        static void DisplayOption9(String[] movie, int[] rating, int[] category)
        {
            bool found = false;
            int categoryNo;
            int i = 0;
            Console.Write("Enter category no.: ");// your code goes here
            categoryNo = int.Parse(Console.ReadLine());

            for (i = 0; i < category.Length; i++)
            {
                if(categoryNo == category[i])
                {
                    Console.WriteLine("{0}", movie[i]);
                    found = true;

                }
              
               
            }
            if (found == false)
            {
                Console.WriteLine("category {0} not found", categoryNo);
            }


            Console.ReadLine();

        }
        static void DisplayOption10(String[] movie, int[] rating)
        {
            int i = 0, newRating = 0;
            string movieName =" ";
            Console.WriteLine();
            Console.WriteLine("Enter movie name: ");
            movieName = Console.ReadLine();
            Console.WriteLine("Enter new rating: ");
            newRating = int.Parse(Console.ReadLine());
            for (i = 0; i < movie.Length; i++)// your code goes here
            {
                if (movieName == movie[i])
                    rating[i] = newRating;
            }
            Console.ReadLine();
        }
        static void DisplayOption11(String[] movie, int[] rating)
        {
            Console.WriteLine("Movies");
            // your code goes here 

            Console.ReadLine();
        }
        static void DisplayOption12(int[] category, String[] movie, int[] rating, String[]
        categoryName)
        {
            Console.WriteLine();
            Console.WriteLine("Movie\t\t\t\tRating");
            // your code goes here
            Console.ReadLine();
        }
        static int DisplayMenu()
        {
            int choice;
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("1. Display Movies");
            Console.WriteLine("2. Display Movies (last index to index 0)");
            Console.WriteLine("3. Display Average Movie Rating");
            Console.WriteLine("4. Display Above Average Rating");
            Console.WriteLine("5. Display Highest Rating");
            Console.WriteLine("6. Display Lowest Rating");
            Console.WriteLine("7. Display a Movie Rating");
            Console.WriteLine("8. Display Above, EqualTo and Below Movie Rating");
            Console.WriteLine("9. Display movies in a specific category");
            Console.WriteLine("10. Update Rating");
            Console.WriteLine("11. Display Rating ");
            Console.WriteLine("12. Display Average Category Rating ");
            Console.WriteLine("13. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return choice;
        }

    
    }
}
