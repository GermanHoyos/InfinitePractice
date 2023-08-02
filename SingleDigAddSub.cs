using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace infinitePractice
{
    public static class AdditionSubtraction
    {
        public static int displayCount = 0;
        public static int questionCount = 50;

        public static void AdditionSubtractionQuestions()
        {
            int userAnswer;
            int correctAnswers = 0;
            Random randomNumber = new Random();

            for (int i = 0; i < questionCount; i++)
            {
                int a = randomNumber.Next(1, 10);
                int b = randomNumber.Next(1, 10);

                // Decide whether to ask an addition or subtraction question randomly
                bool isAddition = randomNumber.Next(2) == 0;

                if (isAddition)
                {
                    Console.WriteLine(a.ToString() + " + " + b.ToString() + " = ");
                    if (int.TryParse(Console.ReadLine(), out userAnswer))
                    {
                        if (userAnswer == a + b)
                        {
                            Console.WriteLine("Question: " + i + " is Correct!");
                            correctAnswers++;
                        }
                        else
                        {
                            Console.WriteLine("Question: " + i + " is Incorrect! The correct answer is: " + (a + b));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Question: " + i + " Invalid input. Please enter a valid integer.");
                    }
                }
                else
                {
                    Console.WriteLine(a.ToString() + " - " + b.ToString() + " = ");
                    if (int.TryParse(Console.ReadLine(), out userAnswer))
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
                }

                Console.ReadLine();
            }

            Console.WriteLine("You got " + correctAnswers + " out of " + questionCount + " questions correct.");
        }
    }
}
