using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitePractice
{
    public static class Make10
    {
        public static int displayCount = 0;
        public static int questionCount = 50;

        public static void Make10Questions()
        {
            int usrInp;
            Random RandomNumber = new Random();

            for (int i = 0; i < questionCount; i++)
            {
                int num = RandomNumber.Next(1, 10);

                Console.WriteLine(num + " distance from 10 is:");
                Console.ReadLine();
                Console.WriteLine(10 - num);
                Console.ReadLine();
            }
            return;
        }
    }
}
