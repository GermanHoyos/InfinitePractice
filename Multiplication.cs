using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
    public static class Multiplication
    {
        public static int displayCount = 0;
        public static int questionCount = 50;

        public static void MultiplicationQuestions()
        {
            int usrInp;
            Random RandomNumber = new Random();

            for (int i = 0; i < questionCount; i++)
            {
                int a, b;

                // Ensure a is not 10 or 11
                do
                {
                   a = RandomNumber.Next(2, 12); // Generates numbers between 2 and 11
                } while (a == 10 || a == 11);

                // Ensure b is not 10 or 11
                do
                {
                    b = RandomNumber.Next(2, 12); // Generates numbers between 2 and 11
                } while (b == 10 || b == 11);

                Console.WriteLine(a.ToString() + " * " + b.ToString() + " = ");
                Console.ReadLine();
                Console.WriteLine(a * b);
                Console.ReadLine();
            }
            return;
        }
    }
}
