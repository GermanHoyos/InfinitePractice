using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
    public static class PrimeNumbers
    {
        public static int displayCount = 0;
        public static int questionCount = 46; // Number of primes up to 200
        public static int currentPrimeIndex = 0;
        public static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 };

        public static void PrimeNumberQuestions()
        {
            int correctAnswer;

            for (int i = 0; i < questionCount; i++)
            {
                correctAnswer = primes[currentPrimeIndex];

                Console.WriteLine($"What is the next prime number after {correctAnswer - 1}? (Enter the prime number)");
                string userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput) || !int.TryParse(userInput, out int usrInp))
                {
                    Console.WriteLine($"Incorrect or invalid input! The correct prime number is: {correctAnswer}");
                }
                else if (usrInp == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct prime number is: {correctAnswer}");
                }

                currentPrimeIndex++;
            }

            Console.WriteLine("Congratulations! You've practiced all prime numbers up to 200.");
            return;
        }
    }
}
