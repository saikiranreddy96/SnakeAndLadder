using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public int start_Position = 0;
        public void StartPosition()
        {
            Console.WriteLine("Game starts now");
            Console.WriteLine("Starting position of player is: " + start_Position);
            Console.ReadLine();
        }
    }
}
