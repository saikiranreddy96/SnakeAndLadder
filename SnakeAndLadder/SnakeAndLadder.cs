using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public int startPosition = 0,DieRoll;
        public void RollTheDie()
        {
            Console.WriteLine("Starting position of a player is : " + startPosition);
            Random random = new Random();
            DieRoll = random.Next(1, 7);
            Console.WriteLine("Player gets the Die Number : " + DieRoll);
            Console.ReadLine();
        }
    }
}
