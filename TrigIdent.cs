using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
    public static class TrigIdentities
    {
        public static int displayCount = 0;
        public static int questionCount = 7;
        
        public static string question_1 = "sin^2(theta) + cos^2(theta) = ";
        public static string q1_answer = "1";
        
        public static string question_2 = "tan(theta) = ";
        public static string q2_answer = "sin(theta) / cos(theta)";
        
        public static string question_3 = "cot(theta) = ";
        public static string q3_answer = "cos(theta) / sin(theta)";
        
        public static string question_4 = "sec(theta) = ";
        public static string q4_answer = "1 / cos(theta)";
        
        public static string question_5 = "csc(theta) = ";
        public static string q5_answer = "1 / sin(theta)";
        
        public static string question_6 = "sin(2theta) = ";
        public static string q6_answer = "2 * sin(theta) * cos(theta)";
        
        public static string question_7 = "cos(2theta) = ";
        public static string q7_answer = "cos^2(theta) - sin^2(theta)";
        
        public static void TrigIdentityQuestions()
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
                    case 6:
                        Console.WriteLine(question_6);
                        Console.ReadLine();
                        Console.WriteLine(q6_answer);
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine(question_7);
                        Console.ReadLine();
                        Console.WriteLine(q7_answer);
                        Console.ReadLine();
                        break;
                }
            }
            return;
        }
    }
}