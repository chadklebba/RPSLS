using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string playerChoice;
        public string playerName;
        public int playerScore = 0;

        public void PlayerName()
        {
            playerName = Console.ReadLine();
        }

        public virtual void PlayerChoose()
        {
            Console.WriteLine("What is your choice:" + "\n");
            Console.WriteLine("(1) Rock" + "\r");
            Console.WriteLine("(2) Paper" + "\r");
            Console.WriteLine("(3) Scissors" + "\r");
            Console.WriteLine("(4) Lizard" + "\r");
            Console.WriteLine("(5) Spock" + "\r");
            string playerNumber = Console.ReadLine();
            switch (playerNumber)
            {
                case "1":
                    playerChoice = "Rock";
                    break;
                case "2":
                    playerChoice = "Paper";
                    break;
                case "3":
                    playerChoice = "Scissors";
                    break;
                case "4":
                    playerChoice = "Lizard";
                    break;
                case "5":
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

