using System;
using System.Collections.Generic;
using System.Text;
namespace SnakeAndLadder
{
    public class UC2
    {
        public static void Main(string[] args)
        {
            int StartPosition = 0;
            int PresentPosition = 0;
            Random random = new Random();
            int DiceNo = random.Next(1, 7);

            {
                Console.WriteLine("Welcome to the Snake and Ladder Game");
                Console.WriteLine("....................................");

                Console.WriteLine("The Start Position of The Player is : {0}", StartPosition);
                Console.WriteLine("....................................");

                Console.WriteLine("The Dice is rolled");
                Console.WriteLine("....................................");


                while (PresentPosition <= 100)

                {
                    PresentPosition++;
                    Random ran = new Random();
                    int Option = ran.Next(1, 4);

                    Console.WriteLine("....................................");

                    Console.WriteLine("The Dice Number is : {0}", Option);
                    Console.WriteLine("....................................");

                    if (Option == 1)
                    {
                        PresentPosition = PresentPosition;

                        Console.WriteLine("No Play for the Player");
                        Console.WriteLine("The Start Position of The Player is : {0}", PresentPosition);

                    }
                    else if (Option == 2)
                    {
                        PresentPosition = PresentPosition + DiceNo;
                        Console.WriteLine("Palyer Move Ahead");
                        Console.WriteLine("The Present Position of The Player is : {0}", PresentPosition);

                    }
                    else
                    {
                        Console.WriteLine("Palyer Move Behind");
                        if (StartPosition >= 0 && StartPosition >= DiceNo)
                        {
                            PresentPosition = PresentPosition - DiceNo;
                            Console.WriteLine("The Present Position of The Player is : {0}", PresentPosition);

                        }
                    }
                    PresentPosition++;
                }
            }
        }
    }
}
