using Fractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
	public static class FractionCustomClass
	{
		public static int displayCount = 0;
		public static int questionCount = 7;
		public static void FractionQuestions()
		{
			int usrInp;
			Random RandomNumber = new Random();
			

			for (int i = 0; i < questionCount; i++)
			{
				int fractionNumeratorA = RandomNumber.Next(1,10);
				int fractionDenominatorA = RandomNumber.Next(1,10);

				int fractionNumeratorB = RandomNumber.Next(1,10);
				int fractionDenominatorB = RandomNumber.Next(1,10);
	            var a = new Fraction(fractionNumeratorA, fractionDenominatorA);
				var b = new Fraction(fractionNumeratorB,fractionDenominatorB);
				var c = new Fraction(1,1);				

				Console.WriteLine(a + " + " + b + " = ");
				Console.ReadLine();
				var instance = new Fraction();
				c = instance.Add(a + b);
				Console.WriteLine("Answer " + " = " + c);
				Console.ReadLine();
			}
			return;
		}		
	}
}
