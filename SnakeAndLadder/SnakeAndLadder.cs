using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public int DieRoll;
        public void RollADie()
        {
            Random random = new Random();
            DieRoll = random.Next(1, 7);
            Console.WriteLine("Player gets the die number : " + DieRoll);
            Console.ReadLine();
        }
    }
}
