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
            //Enter or exit logic
            string userChoice = ();
            //while (userChoice != "no")
            do
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

                }
                // Console.WriteLine(sixNumb[0] + sixNumb[1], sixNumb[2], sixNumb[3], sixNumb[4], sixNumb[5]);
                //Console.WriteLine(sixNumb[0]);
                //Console.WriteLine(sixNumb[1]);
                //Console.WriteLine(sixNumb[2]);
                //Console.WriteLine(sixNumb[3]);
                //Console.WriteLine(sixNumb[4]);
                //Console.WriteLine(sixNumb[5]);
                //Console.WriteLine(sixNumb[6]);

                //Random Number Gen
                Random r = new Random();
                int[] rArray = new int[6];

                for (int i = 0; i < rArray.Length; i++)
                {
                    rArray[i] = r.Next(lowNumb, highNumb);
                    Console.WriteLine("Lucky Number: " + rArray[i]);
                }

                //Comparison of User numbers vs. Random Numbers


                for (int i = 0; i < sixNumb.Length; i++)
                {
                    for (int k = 0; k < rArray.Length; k++)
                    {
                        bool numbCompare = (sixNumb[i] == rArray[i]);
                        if (numbCompare = (sixNumb[i] == rArray[i])) ;

                        {
                            int winCount = 0;
                            while (numbCompare == true)
                            {
                                Console.WriteLine("You guessed {0} numbers correctly!", winCount);
                                //Winnings calculation
                                //int winningCalc = (jackpot / winCount);
                                //Console.WriteLine("You won $" + winningCalc + "!");
                                switch (winCount)
                                {
                                    case 1:
                                        Console.WriteLine("You won $1000!");
                                        break;
                                    case 2:
                                        Console.WriteLine("You won $2000!");
                                        break;
                                    case 3:
                                        Console.WriteLine("You won $3000!");
                                        break;
                                    case 4:
                                        Console.WriteLine("You won $4000!");
                                        break;
                                    case 5:
                                        Console.WriteLine("You won $5000!");
                                        break;
                                    case 6:
                                        Console.WriteLine("You won $6000!");
                                        break;

                                    default:
                                        Console.WriteLine("You won $0!");
                                        break;
                                }
                            }
                        }
                    }
                }

                //Oppotunity to play again
                Console.WriteLine("Do you want to play again? Type 'yes' OR type 'no' to leave.");
                userChoice = (Console.ReadLine());
                //if (userChoice.ToLower().Equals("yes"))
                //{
                //    //execute what?
                //}
                //if (userChoice.ToLower().Equals("no"))
                //{
                //    Console.WriteLine("Thanks for playing!");
                //    //exit code here
                //}
            } while (userChoice != "no");
        }
    }
}
