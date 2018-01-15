using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {

        static void Main(string[] args)
        {
            Game game = new Game();
            game.DisplayInstruction();
            game.ChoosePlayers();
            while (game.playerOne.playerScore < 2 & game.playerTwo.playerScore < 2)
            {
                game.Turn();
                Console.Clear();
                Console.WriteLine(game.playerOne.playerName + " chose " + game.playerOne.playerChoice + "\r");
                Console.WriteLine(game.playerTwo.playerName + " chose " + game.playerTwo.playerChoice + "\r");
                game.FindWinner();
            }
            game.DeclareWinner();
            Console.ReadLine();

        }
    }
}

