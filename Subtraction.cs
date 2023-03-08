using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
	public static class Subtraction
	{
		public static int displayCount = 0;
		public static int questionCount = 20;



		public static void SubtractionQuestion()
		{
			int usrInp;
			Random RandomNumber = new Random();			

			for (int i = 0; i < questionCount; i++)
			{
				int a = RandomNumber.Next(1,200);
				int b = RandomNumber.Next(1,200);
				int c = 0;
				Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " );
				Console.ReadLine();
				c = a - b;
				Console.WriteLine("Answer is: " + c);
				Console.ReadLine();
			}
			return;
		}
	}
}
