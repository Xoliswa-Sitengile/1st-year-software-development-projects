using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _23_Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = DisplayMenu();
            while (choice != 3)
            {
                if (choice == 1)
                    Option1();
                else if (choice == 2)
                    Option2();
                choice = DisplayMenu();
            } // end loop
            Console.ReadLine();
        }


        static int DisplayMenu()
        {
            int choice;
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return choice;
        }
        static void Option1()
        {
            Console.Clear();
            string[] studentNames = new string[3];
            int[] testMark1 = new int[3];
            int[] testMark2 = new int[3];
            int[] testMark3 = new int[3];
            int[] testMark4 = new int[3];

            //step 1
            int i = 0, lowest = 102;
            string[] array;
          
            StreamReader myReader = new StreamReader("StudentMarksSplit.txt");
            for (i = 0; i < studentNames.Length; i++)
            {
                array = myReader.ReadLine().Split('#', ',');
                studentNames[i] = array[0];
                testMark1[i] = int.Parse(array[1]);
                testMark2[i] = int.Parse(array[2]);
                testMark3[i] = int.Parse(array[3]);
                testMark4[i] = int.Parse(array[4]);

                //step 2
                lowest = Math.Min(testMark1[i], testMark2[i]);
                lowest = Math.Min(lowest, testMark3[i]);
                lowest = Math.Min(lowest, testMark4[i]);

                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}", studentNames[i], testMark1[i], testMark2[i], testMark3[i], testMark4[i], lowest);
                lowest = 102;
            }
            myReader.Close();

            Console.ReadLine();
        }


        static void Option2()
        {
            Console.Clear();
            // write all the code in here
            string[] studentNames = new string[5];
            int[] finalMark = new int[5];
            string[] array;
            int i;
 
            StreamReader myReader = new StreamReader("StudentMarksSplit2.txt");
            for (i = 0; i < studentNames.Length; i++)
            {
                //step 1
                array = myReader.ReadLine().Split(' ', ',');
                studentNames[i] = array[0];
                finalMark[i] = int.Parse(array[2]);

            }
            myReader.Close();

            //step2
            int highest = 0;
            int totalAbove = 0;
            int totalBelow = 0;

            for (i = 0; i < studentNames.Length; i++)
            {
                //step 2
                highest = Math.Max(highest, finalMark[i]);

            }

            for (i = 0; i < studentNames.Length; i++)
            {
                if (finalMark[i] == highest)
                    Console.WriteLine("{0}\t{1}***", studentNames[i], finalMark[i]);
                else
                    Console.WriteLine("{0}\t{1}", studentNames[i], finalMark[i]);
                //determining totals
                if (finalMark[i] > 50)
                    totalAbove++;
                else
                        totalBelow++;
            }

            Console.WriteLine();
            Console.WriteLine("Total above equal 50: {0}", totalAbove);
            Console.WriteLine("Total below 50: {0}", totalBelow);
            Console.ReadLine();
        }
    }
}
