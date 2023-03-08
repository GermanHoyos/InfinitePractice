using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
	public static class Make100
	{
		public static int displayCount = 0;
		public static int questionCount = 10;
		public static void Make100Questions()
		{
			int usrInp;
			Random RandomNumber = new Random();

			for (int i = 0; i < questionCount; i++)
			{
				int num = RandomNumber.Next(1,100);
				
				Console.WriteLine(num + " distance from 100 is:");
				Console.ReadLine();
				Console.WriteLine(100 - num);
				Console.ReadLine();

			}
			return;	
		}
	}
}
