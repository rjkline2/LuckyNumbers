using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            int jackpot = 6000;
            Console.WriteLine("Welcome to Lucky Numbers!!!");
            Console.WriteLine("Today's Jackpot total is: " + "$" + jackpot);
            
            //User input and populating arrays
            Console.WriteLine("Please enter the starting number:");
            int lowNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the ending number:");
            int highNumb = int.Parse(Console.ReadLine());
            int[] sixNumb = new int[6];
            for (int i = 0; i < sixNumb.Length; i++)
            {
                Console.WriteLine("Please enter six numbers between: " + lowNumb + " and " + highNumb);
                sixNumb[i] = int.Parse(Console.ReadLine());
                if (sixNumb[i] < lowNumb)
                {
                    Console.WriteLine("Number too low! Please enter a number between: " + lowNumb + " and " + highNumb);
                    sixNumb[i] = int.Parse(Console.ReadLine());
                }
                if (sixNumb[i] > highNumb)
                {
                    Console.WriteLine("Number too high! Please enter a number between: " + lowNumb + " and " + highNumb);
                    sixNumb[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(sixNumb[0]);
            Console.WriteLine(sixNumb[1]);
            Console.WriteLine(sixNumb[2]);
            Console.WriteLine(sixNumb[3]);
            Console.WriteLine(sixNumb[4]);
            Console.WriteLine(sixNumb[5]);
            Console.WriteLine(sixNumb[6]);
            }
            // Console.WriteLine(sixNumb[0] + sixNumb[1], sixNumb[2], sixNumb[3], sixNumb[4], sixNumb[5]);
            

            //Random Number Gen
            Random r = new Random();
            int[] rArray = new int[6];

            for (int i = 0; i < rArray.Length; i++)
            {
                rArray[i] = r.Next(lowNumb, highNumb);
                Console.WriteLine("Lucky Number: " + rArray[i]);
            }

            //Comparison of User numbers vs. Random Numbers



        }
    }
}
