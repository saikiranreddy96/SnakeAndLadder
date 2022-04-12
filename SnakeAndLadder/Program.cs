using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game\n");

            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
            snakeAndLadder.StartPlaying();
            
        }
    }
}
