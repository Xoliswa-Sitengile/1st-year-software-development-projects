using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberQuestions = 0, i = 0, testQuestionsNumber = 0, correctAnswers = 0,incorrectAnswers = 0, pass = 0, fail = 0;
            string result = " ";
            double percentage = 0;
            Console.Write("Please enter the number of questions: ");
            numberQuestions = int.Parse(Console.ReadLine());

            string[] questions = new string[numberQuestions]; //array declaration
            string[] missingWords = new string [numberQuestions];
            string[] userAnswer = new string [numberQuestions];
            Console.WriteLine();
            Console.WriteLine("PLEASE SET UP THE TEST BELOW");
            Console.WriteLine();
            for (i = 0; i < numberQuestions; i++)
            {
                Console.Write("Enter question {0}: ", i + 1);
                questions[i] = Console.ReadLine(); // answers from the user (teacher)
                Console.Write("Missing word for question {0}: ", i + 1);
                missingWords[i] = Console.ReadLine();
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("FILL IN THE MISSING WORDS: ");
            Console.WriteLine();
           for (i = 0; i < numberQuestions;i++)
           {
                Console.WriteLine("Question {0}\n==========",i + 1); // answers from the user 
                Console.WriteLine("___ {0}",questions[i]);
                Console.Write("Enter missing words: ");
                userAnswer[i] = Console.ReadLine();
           }
            Console.Clear();
            Console.WriteLine("TEST MEMO\n=========");
            for (i = 0; i < numberQuestions; i++)
            {
                Console.WriteLine("QUESTION {0}:___{1}", i + 1, questions[i]);
                Console.WriteLine("Missing words: {0}",missingWords[i]); // answers from the user (teacher)
                Console.WriteLine("Your answer: {0}", userAnswer [i]); //answers fro the user
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("RESULT OF TEST\n================");
            Console.WriteLine();
            for (i =0; i < numberQuestions; i++)
            {
                if (missingWords[i] == userAnswer[i])
                    correctAnswers++;
                else
                    incorrectAnswers++;
            }
            percentage = (double) correctAnswers / numberQuestions * 100;
            if (percentage < 40)
                result = "FAIL";
            else if (percentage >= 40 && percentage > 75)
                result = "PASS";
            else if (percentage >= 75)
                result = "PASS WITH DISTINCTION";

            Console.WriteLine("Number of test question: \t\t\t{0}",numberQuestions);
            Console.WriteLine();
            Console.WriteLine("Number of correct answers: \t\t\t{0}",correctAnswers);
            Console.WriteLine("Number of incorrect answers: \t\t\t{0}",incorrectAnswers);
            Console.WriteLine();
            Console.WriteLine("Test percentage (pass): \t\t\t{0}", percentage);
            Console.WriteLine("Test percentage (fail): \t\t\t{0}",100 - percentage);
            Console.WriteLine();
            Console.WriteLine("Result of Test: {0}", result);
            Console.ReadLine();
        }
    }
}
