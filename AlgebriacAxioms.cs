using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
	public static class AlgebriacAxioms
	{
		public static int displayCount = 0;
		public static int questionCount = 11;
		
		public static string question_1 = "a+(b+c) = " ;				public static string q1_answer = "(a+b)+c"; 
		public static string question_2 = "a+b = ";						public static string q2_answer = "b+a";
		public static string question_3 = "a*(b*c) = ";					public static string q3_answer = "(a*b)*c";
		public static string question_4 = "a*(b+c) = ";					public static string q4_answer = "(a*b)+(a*c)";
		public static string question_5 = "a*1/a = ";					public static string q5_answer = "1";
		public static string question_6 = "a^m*a^n = ";					public static string q6_answer = "a^m+n";
		public static string question_7 = "(a^m)^n = ";					public static string q7_answer = "a^m*n";
		public static string question_8 = "(ab)^n = ";					public static string q8_answer = "a^n*b^n";
		public static string question_9 = "(a/b)^n = ";					public static string q9_answer = "a^n/b^n";
		public static string question_10= "Version 1: a^m/a^n = ";		public static string q10_answer= "a^m-n";
		public static string question_11= "Version 2: a^m/a^n = ";		public static string q11_answer= "1/a^n-m";
		
		public static void AlgebriacAxiomQuestions()
		{
			int usrInp;

			for (int i = 0; i < questionCount; i++)
			{
				switch(i)
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
					case 8:
						Console.WriteLine(question_8);
						Console.ReadLine();
						Console.WriteLine(q8_answer);
						Console.ReadLine();

						break;
					case 9:
						Console.WriteLine(question_9);
						Console.ReadLine();
						Console.WriteLine(q9_answer);
						Console.ReadLine();

						break;
					case 10:
						Console.WriteLine(question_10);
						Console.ReadLine();
						Console.WriteLine(q10_answer);
						Console.ReadLine();

						break;
					case 11:
						Console.WriteLine(question_11);
						Console.ReadLine();
						Console.WriteLine(q11_answer);
						Console.ReadLine();

						break;
				}
			}
			return;
		}

	}
}
