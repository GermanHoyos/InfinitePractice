using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
    internal class Exponents
    {
        public static int questionCount = 14;
        public static int decrement = 15;

        //String questions
        public static string question_1 = "  n   m    \n" +
                                          " x * x =   \n" ;

        public static string q1_answer  = "  n+m      \n" +
                                          " x         \n" ;

        public static string question_2 = "      m     \n" +
                                          "  / n\\   \n" +
                                          "  |a |     \n" +
                                          "  \\  /     \n" +
                                          "           \n" ;

        public static string q2_answer  = "   n*m     \n" +
                                          "  a        \n" +
                                          "           \n" +
                                          "           \n" +
                                          "           \n" ;

        public static string question_3 = "     n     \n" +
                                          " (ab) =    \n" +
                                          "           \n" +
                                          "           \n" +
                                          "           \n" ;

        public static string q3_answer =  "   n   n   \n" +
                                          "  a * b    \n" +
                                          "           \n" +
                                          "           \n" +
                                          "           \n" ;

        public static string question_4 = "   -n      \n" +
                                          "  a  =     \n" +
                                          "           \n" +
                                          "           \n" +
                                          "           \n" ;

        public static string q4_answer =  "           \n" +
                                          "    1      \n" +
                                          "   ---     \n" +
                                          "     n     \n" +
                                          "    a      \n" ;

        public static string question_5 = "     -n    \n" +
                                          "  /a\\     \n" +
                                          " | - | =   \n" +
                                          "  \\b/     \n" +
                                          "           \n" ;

        public static string q5_answer =  "      n       n      \n" +
                                          "  /b\\        b      \n" +
                                          " | - |  ==  ---      \n" +
                                          "  \\a/         n     \n" +
                                          "             a       \n" ;

        public static string question_6 = "    n       \n" +
                                          "   a        \n" +
                                          "  --- =     \n" +
                                          "    m       \n" +
                                          "   a        \n" ;

        public static string q6_answer =  "                 \n" +
                                          "   n-m     1     \n" +
                                          "  a    == ---    \n" +
                                          "            m-n  \n" +
                                          "           a     \n" ;

        public static string question_7 = "   0               \n" +
                                          "  a =              \n" +
                                          "                   \n" +
                                          "  as long as:      \n" +
                                          "  (a != 0)         \n" ;

        public static string q7_answer =  "           \n" +
                                          "           \n" +
                                          "   a = 1   \n" +
                                          "           \n" +
                                          "           \n" ;

        public static string question_8 = "       n    \n" +
                                          "   /a\\     \n" +
                                          "  | - |  =  \n" +
                                          "   \\b/     \n" +
                                          "            \n" ;

        public static string q8_answer =  "    n       \n" +
                                          "   a        \n" +
                                          "  ---       \n" +
                                          "    n       \n" +
                                          "   b        \n" ;

        public static string question_9 = "            \n" +
                                          "  1         \n" +
                                          " ---  =     \n" +
                                          "   -n       \n" +
                                          "  a         \n" ;

        public static string q9_answer =  "            \n" +
                                          "  n         \n" +
                                          " a          \n" +
                                          "            \n" +
                                          "            \n" ;

        public static string question_10 = "  n         \n" +
                                           "  -         \n" +
                                           "  m         \n" +
                                           " a  =       \n" +
                                           "            \n" ;

        public static string q10_answer =  "                       1       \n" +
                                           "   / 1 \\n              -      \n" +
                                           "  |  -  |  ==    /  n \\m      \n" +
                                           "  |  m  |       |  a   |       \n" +
                                           "   \\a  /         \\    /      \n" ;

        // RADICALS --------------------------------------------------------------------------------------


        public static string question_11 = "      __               \n" +
                                           "     /                 \n" +
                                           "   \\/ ab  =           \n" +
                                           "                       \n" +
                                           "                       \n" ;

        public static string q11_answer =  "      __     __       \n" +
                                           "     /      /         \n" +
                                           "   \\/ a * \\/ b       \n" +
                                           "                       \n" +
                                           "                       \n" ;

        public static string question_12 = "                      \n" +
                                           "       __ 2          \n" +
                                           "    (\\/a )  =        \n" +
                                           "                      \n" +
                                           "                      \n" ;

        public static string q12_answer =  "                      \n" +
                                           "                      \n" +
                                           "     a                \n" +
                                           "                      \n" +
                                           "                      \n" ;

        public static string question_13 = "     n                \n" +
                                           "    x  = a =          \n" +
                                           "                      \n" +
                                           "                      \n" +
                                           "                      \n" ;

        public static string q13_answer  = "        __           \n" +
                                           "     n /             \n" +
                                           "     \\/  a           \n" +
                                           "                      \n" +
                                           "                      \n" ;

        public static string question_14 = "    1                  \n" +
                                           "    -                  \n" +
                                           "    n                  \n" +
                                           "   a                   \n" +
                                           "                       \n" ;

        public static string q14_answer  = "      __             \n" +
                                           "   n /               \n" +
                                           "   \\/  a             \n" +
                                           "                      \n" +
                                           "                      \n" ;

        public static string question_15 = "   m                   \n" +
                                           "   -                   \n" +
                                           "   n                   \n" +
                                           "  a                    \n" +
                                           "                       \n" ;

        public static string q15_answer  = "                               \n" +
                                           "     ___          /    ___ \\m       \n" +
                                           "  n / m          |  n /     |      \n" +
                                           "  \\/ a  =        |  \\/ a    |      \n" +
                                           "                  \\        /       \n" ;


        public static void ExponentQuestions() 
        {

            

            for (int i = 0; i < questionCount; i++) 
            {
                Console.Clear();
                Random randNum = new Random();
                int randomValue = randNum.Next(1, 10); // Upper bound is exclusive, so 10 gives 1-9

                switch (decrement) 
                {
                    case 1:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_1);
                        Console.ReadLine();
                        Console.Write(q1_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_2);
                        Console.ReadLine();
                        Console.Write(q2_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_3);
                        Console.ReadLine();
                        Console.Write(q3_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_4);
                        Console.ReadLine();
                        Console.Write(q4_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_5);
                        Console.ReadLine();
                        Console.Write(q5_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_6);
                        Console.ReadLine();
                        Console.Write(q6_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_7);
                        Console.ReadLine();
                        Console.Write(q7_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_8);
                        Console.ReadLine();
                        Console.Write(q8_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_9);
                        Console.ReadLine();
                        Console.Write(q9_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_10);
                        Console.ReadLine();
                        Console.Write(q10_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 11:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_11);
                        Console.ReadLine();
                        Console.Write(q11_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 12:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_12);
                        Console.ReadLine();
                        Console.Write(q12_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 13:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_13);
                        Console.ReadLine();
                        Console.Write(q13_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 14:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_14);
                        Console.ReadLine();
                        Console.Write(q14_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                    case 15:
                        Console.WriteLine("___________________");
                        Console.WriteLine(question_15);
                        Console.ReadLine();
                        Console.Write(q15_answer);
                        Console.WriteLine("___________________");
                        Console.ReadLine();
                        break;
                }
                decrement--;
            }
            return;
        }

    }
}
