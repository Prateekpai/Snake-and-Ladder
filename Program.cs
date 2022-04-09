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
            int PresentPositionofPlayer = 0;
            int DiceCount = 0;



            Console.WriteLine("The Start Position of The Player is : {0}", StartPosition);
            Console.WriteLine("....................................");

            Console.WriteLine("The Dice is rolled");
            Console.WriteLine("....................................");


            while (PresentPositionofPlayer <= 100)

            {
                PresentPositionofPlayer++;
                DiceCount++;
                Random random = new Random();
                int DiceNo = random.Next(1, 7);

                Console.WriteLine("THE DICE NUMBER IS {0}", DiceNo);
                Console.WriteLine("....................................");


                Random ran = new Random();
                int Option = ran.Next(3);

                Console.WriteLine("....................................");

                Console.WriteLine("The Option is : {0}", Option);
                Console.WriteLine("....................................");

                       
                            if (Option == 1)
                            {
                                PresentPositionofPlayer = PresentPositionofPlayer + StartPosition;

                                Console.WriteLine("No Play for the Player");

                            }
                            else if (Option == 2)
                            {
                                PresentPositionofPlayer= PresentPositionofPlayer + DiceNo;
                                Console.WriteLine("Palyer Move Ahead");

                            }
                            else
                            {
                                Console.WriteLine("Palyer Move Behind");
                                if (StartPosition >= 0 && StartPosition >= DiceNo)
                                {
                                    PresentPositionofPlayer = PresentPositionofPlayer - DiceNo;
                                }
                            }
                            Console.WriteLine("The Present Position of The Player is : {0}", PresentPositionofPlayer);
                            Console.WriteLine("\n.......................................\n");
                            Console.WriteLine("The Dice Count is : {0}", DiceCount);

            
            }
        }
    }
}

