using System;
using System.Collections.Generic;
using System.Text;
namespace SnakeAndLadder
{
    public class UC3
    {
        public static void Main(string[] args)
        {
            int StartPosition = 0;
            int CurrentPosition = 0;

            int ioption = 0;
            int joption = 1;

            Random rdm = new Random();
            int GameOption = rdm.Next(3);

            Random random = new Random();
            int DiceNo = random.Next(1, 7);


            {
                Console.WriteLine("Welcome to the Snake and Ladder Game");
                Console.WriteLine("....................................");
                Console.WriteLine(" The Start Position of The Player is : {0}", StartPosition);
                Console.WriteLine("The Dice Number is : {0}", DiceNo);
            }

            {
                Console.WriteLine(GameOption);
            }
            {
                if ((GameOption != ioption))
                {
                    if (GameOption = joption)
                    {
                        Console.WriteLine("The Player get the Ladder :");
                        CurrentPosition = StartPosition + DiceNo;
                        
                    }
                    else
                    {
                        Console.WriteLine("The Player bited by Snake : {0}", DiceNo);
                        CurrentPosition = StartPosition - DiceNo;

                    }
                    {
                        Console.WriteLine("The Player Position is : {0}", DiceNo);
                        CurrentPosition = StartPosition;
                    }
                }
                //}
            }
        }
    }
}
