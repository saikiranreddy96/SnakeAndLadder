using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        public int player_Position = 0, DieRoll;
        public void StartPlaying()
        {
            Console.WriteLine("Starting position of a player is : " + player_Position);
            Random random = new Random();
            DieRoll = random.Next(1, 7);
            Console.WriteLine("Player gets the Die Number : " + DieRoll);

            switch (random.Next(0, 3))
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;

                case LADDER:
                    player_Position += DieRoll;
                    Console.WriteLine("Ladder: " + player_Position);
                    break;
                case SNAKE:
                    player_Position -= DieRoll;
                    Console.WriteLine("Snake: " + player_Position);
                    break;
            }
            Console.ReadLine();
        }
    }
}







       