using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
	public static class Devision
	{
		public static int displayCount = 0;
		public static int questionCount = 20;
		public static void DevisionQuestions()
		{
			int usrInp;
			Random RandomNumber = new Random();			

			for (int i = 0; i < questionCount; i++)
			{
				int a = RandomNumber.Next(1,100);
				int b = RandomNumber.Next(1,100);
				Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " );
				Console.ReadLine();
				Console.WriteLine(Decimal.Divide(a,b));
				Console.ReadLine();
			}
			return;
		}
	}
}
