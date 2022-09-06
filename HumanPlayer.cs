using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            int res = 0;
            Console.Write("Enter your roll: ");
            while (int.TryParse(Console.ReadLine(), out res) == false) 
            {
                Console.Write("Invalid Input, Try again: ");
            }
            return res;
        }
    }
}