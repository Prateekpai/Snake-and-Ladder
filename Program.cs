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
            Random random = new Random();
            int DiceNo = random.Next(1, 7);

            {
                Console.WriteLine("Welcome to the Snake and Ladder Game");
                Console.WriteLine("....................................");
                Console.WriteLine("The Start Position of The Player is : {0}", StartPosition);
                Console.WriteLine("The Dice Number is : {0}",DiceNo);   
            }
        }
    }

}