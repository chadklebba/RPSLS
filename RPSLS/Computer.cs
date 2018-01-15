using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player 
    {
        public Computer()
        {
            playerName = "Sheldon";
        }

        public override void PlayerChoose()
        {
            Random rand = new Random();
            int playerNumber = (rand.Next(1, 6));
            switch (playerNumber)
            {
                case 1:
                    playerChoice = "Rock";
                    break;
                case 2:
                    playerChoice = "Paper";
                    break;
                case 3:
                    playerChoice = "Scissors";
                    break;
                case 4:
                    playerChoice = "Lizard";
                    break;
                case 5:
                    playerChoice = "Spock";
                    break;
                default:
                    Console.WriteLine("Please pick a number in between 1 and 5");
                    PlayerChoose();
                    break;
            }
        }
    }
}
