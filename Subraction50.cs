using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
    public static class Subtraction50
    {
        public static int displayCount = 0;
        public static int questionCount = 50;

        public static void SubtractionQuestions()
        {
            int userAnswer;
            int correctAnswers = 0;
            Random randomNumber = new Random();

            for (int i = 0; i < questionCount; i++)
            {
                int a = randomNumber.Next(1, 1000);
                int b = randomNumber.Next(1, 1000);

                // Ensure that the first number is greater than or equal to the second number
                if (a < b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }

                Console.WriteLine(a.ToString() + " - " + b.ToString() + " = ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userAnswer))
                {
                    if (userAnswer == a - b)
                    {
                        Console.WriteLine("Question: " + i + " is Correct!");
                        correctAnswers++;
                    }
                    else
                    {
                        Console.WriteLine("Question: " + i + " is Incorrect! The correct answer is: " + (a - b));
                    }
                }
                else
                {
                    Console.WriteLine("Question: " + i + " Invalid input. Please enter a valid integer.");
                }

                Console.ReadLine();
            }

            Console.WriteLine("You got " + correctAnswers + " out of " + questionCount + " questions correct.");
        }
    }
}
