using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
	public static class SquareRoots
	{
		public static int displayCount = 0;
		public static int questionCount = 10;
		public static void SquareRootQuestions()
		{
			int usrInp;
			Random RandomNumber = new Random();

			for (int i = 0; i < questionCount; i++)
			{
				int findRootOf = RandomNumber.Next(1,100);
				
				Console.WriteLine("Square Root: "  + findRootOf);
				Console.ReadLine();
				Console.WriteLine(Math.Sqrt(findRootOf));
				Console.ReadLine();
			}
			return;	
		}
	}
}
