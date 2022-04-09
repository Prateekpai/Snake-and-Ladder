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
            int PresentPositionofPlayer1 = 0;
            int PresentPositionofPlayer2 = 0;


            Console.WriteLine("The Start Position of The Player is : {0}", StartPosition);
            Console.WriteLine("....................................");

            Console.WriteLine("The Dice is rolled");
            Console.WriteLine("....................................");


            while (PresentPositionofPlayer1 <= 100 && PresentPositionofPlayer2 <= 100)

            {
                PresentPositionofPlayer1++;
                PresentPositionofPlayer2++;
                Random random = new Random();
                int DiceNo = random.Next(1, 7);

                Console.WriteLine("THE DICE NUMBER IS {0}", DiceNo);
                Console.WriteLine("....................................");


                Random ran = new Random();
                int Option = ran.Next(3);

                Console.WriteLine("....................................");

                Console.WriteLine("The Option is : {0}", Option);
                Console.WriteLine("....................................");

                int Player = 2;
                switch (Player)
                {
                    case 1:
                        Console.WriteLine("Player1 Turn");
                        {
                            if (Option == 1)
                            {
                                PresentPositionofPlayer1 = PresentPositionofPlayer1 + StartPosition;

                                Console.WriteLine("No Play for the Player");

                            }
                            else if (Option == 2)
                            {
                                PresentPositionofPlayer1 = PresentPositionofPlayer1 + DiceNo;
                                Console.WriteLine("Palyer Move Ahead");

                            }
                            else
                            {
                                Console.WriteLine("Palyer Move Behind");
                                if (StartPosition >= 0 && StartPosition >= DiceNo)
                                {
                                    PresentPositionofPlayer1 = PresentPositionofPlayer1 - DiceNo;
                                }
                            }
                            Console.WriteLine("The Present Position of The Player is : {0}", PresentPositionofPlayer1);

                        }
                        break;

                    case 2:
                        Console.WriteLine("Player2 Turn");
                        {
                            if (Option == 1)
                            {
                                PresentPositionofPlayer2 = PresentPositionofPlayer2 + StartPosition;

                                Console.WriteLine("No Play for the Player");

                            }
                            else if (Option == 2)
                            {
                                PresentPositionofPlayer2 = PresentPositionofPlayer2 + DiceNo;
                                Console.WriteLine("Palyer Move Ahead");

                            }
                            else
                            {
                                Console.WriteLine("Palyer Move Behind");
                                if (StartPosition >= 0 && StartPosition >= DiceNo)
                                {
                                    PresentPositionofPlayer2 = PresentPositionofPlayer2 - DiceNo;
                                }
                            }
                            Console.WriteLine("The Present Position of The Player is : {0}", PresentPositionofPlayer2);

                        }
                        break;
                }
            }

            if (PresentPositionofPlayer1 >= 100)
            {
                Console.WriteLine("Player 1 Winn the Game");

            }
            else
            {
                Console.WriteLine("Player 2 Winn the Game");
            }
        }
    }
}
