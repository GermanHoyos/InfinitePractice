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
        public static int questionCount = 7;

        public static void MultiplicationQuestions()
        {
            int usrInp;
            Random RandomNumber = new Random();

            for (int i = 0; i < questionCount; i++)
            {
                int a = RandomNumber.Next(1, 10);
                int b = RandomNumber.Next(1, 10);
                Console.WriteLine(a.ToString() + " * " + b.ToString() + " = ");
                Console.ReadLine();
                Console.WriteLine(a * b);
                Console.ReadLine();
            }
            return;
        }
    }
}
