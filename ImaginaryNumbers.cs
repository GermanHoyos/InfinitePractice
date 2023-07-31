using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
    public static class ImaginaryNumbers
    {
        public static int displayCount = 0;
        public static int questionCount = 5;
        
        public static string question_1 = "What is the square root of -1? ";
        public static string q1_answer = "i";
        
        public static string question_2 = "What is i^2? ";
        public static string q2_answer = "-1";
        
        public static string question_3 = "What is the complex conjugate of a + bi? ";
        public static string q3_answer = "a - bi";
        
        public static string question_4 = "What is the magnitude of a complex number a + bi? ";
        public static string q4_answer = "sqrt(a^2 + b^2)";
        
        public static string question_5 = "How do you multiply two complex numbers (a + bi) * (c + di)? ";
        public static string q5_answer = "(ac - bd) + (ad + bc)i";
        
        public static void ImaginaryNumberQuestions()
        {
            int usrInp;

            for (int i = 0; i < questionCount; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine(question_1);
                        Console.ReadLine();
                        Console.WriteLine(q1_answer);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(question_2);
                        Console.ReadLine();
                        Console.WriteLine(q2_answer);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine(question_3);
                        Console.ReadLine();
                        Console.WriteLine(q3_answer);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine(question_4);
                        Console.ReadLine();
                        Console.WriteLine(q4_answer);
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine(question_5);
                        Console.ReadLine();
                        Console.WriteLine(q5_answer);
                        Console.ReadLine();
                        break;
                }
            }
            return;
        }
    }
}