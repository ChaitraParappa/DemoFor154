using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FlipCoin
    {
        public static double FlipTheCoin(int flipCoin,int value)
        {
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage=0.0;
            double TailPercentage;

            if (flipCoin > 0)
            {
                for (int i = 1; i <= flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    if (number == 1)
                    {
                        HeadCount++;
                    }
                    else
                    {
                        TailCount++;
                    }

                    Console.WriteLine(number);
                }

                Console.WriteLine("---------------------");

                HeadPercentage = HeadCount * 100 / flipCoin;
                TailPercentage = TailCount * 100 / flipCoin;
              
                Console.WriteLine("Tail Percentage : " + TailPercentage);

            
            }
            Console.WriteLine("After Return Statement");

            return HeadPercentage;
        }
    }
}
