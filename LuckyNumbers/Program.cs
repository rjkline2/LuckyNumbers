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

            //Define Six input number array
            int[] sixNumb = new int[5];

            //User input
            Console.WriteLine("Please enter the starting number:");
            int lowNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the ending number:");
            int highNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number between: " + lowNumb + " and " + highNumb);
            sixNumb[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number between: " + lowNumb + " and " + highNumb);
            sixNumb[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number between: " + lowNumb + " and " + highNumb);
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
