using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
    internal class DecimalDivision
    {
        public static int questionCount = 14;

        public static void DecimalDivisionQuestions()
        {
            Random random = new Random();

            for (int i = 0; i < questionCount; i++)
            {
                decimal a, b;
                int decimalPlacesA, decimalPlacesB;
                int problemType;

                // Generate random integer to determine if this problem is a multiplication problem or division problem
                problemType = random.Next(0, 2);

                // Generate random decimal numbers for a and b with either 2 or 3 decimal places, ensuring neither is zero
                decimalPlacesA = random.Next(0, 3); // 2 or 3 decimal places
                do
                {
                    a = Math.Round((decimal)(random.NextDouble() * 10), decimalPlacesA);
                } while (a == 0);

                decimalPlacesB = 1;
                do
                {
                    b = Math.Round((decimal)(random.NextDouble() * 10), decimalPlacesB);
                } while (b == 0);

                // Display the question based on problem type
                if (problemType == 0) // Multiplication
                {
                    Console.WriteLine($"{a} × {b} = ");
                    Console.ReadLine(); // Wait for user input
                    Console.WriteLine($"Answer: {a * b}\n");
                }
                else // Division
                {
                    Console.WriteLine($"{a} ÷ {b} = ");
                    Console.ReadLine(); // Wait for user input
                    Console.WriteLine($"Answer: {a / b}\n");
                }

                Console.ReadLine(); // Pause before the next question
            }
        }
    }
}



