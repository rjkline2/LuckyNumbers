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
            Console.WriteLine("Welcome to Lucky NUmbers!!!");
            Console.WriteLine("Today's Jackpot total is: " + "$" + jackpot);
            //Define Six input number array and 
            int[] sixNumb = new int[5];
            

            //User input and populating arrays
            Console.WriteLine("Please enter the starting number:");
            int lowNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the ending number:");
            int highNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter six numbers between: " + lowNumb + " and " + highNumb);
            sixNumb[0] = int.Parse(Console.ReadLine());
            if (sixNumb[0] < lowNumb)
            {
                Console.WriteLine("Number too low! Please enter a number between: " + lowNumb + " and " + highNumb);
                sixNumb[0] = int.Parse(Console.ReadLine());
            }
            if (sixNumb[0] > highNumb)
            {
                Console.WriteLine("Number too high! Please enter a number between: " + lowNumb + " and " + highNumb);
                sixNumb[0] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter a second number between: " + lowNumb + " and " + highNumb);
            sixNumb[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a third number between: " + lowNumb + " and " + highNumb);
            sixNumb[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number between: " + lowNumb + " and " + highNumb);
            sixNumb[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number between: " + lowNumb + " and " + highNumb);
            sixNumb[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number between: " + lowNumb + " and " + highNumb);
            sixNumb[5] = int.Parse(Console.ReadLine());
           


            //Random Number Gen
            Random r = new Random();
            int[] rArray = new int[25];

            for (int i = 0; i < rArray.Length; i++)
            {
                rArray[i] = r.Next(lowNumb, highNumb);
                Console.WriteLine(rArray[i]);
            }




        }
    }
}
