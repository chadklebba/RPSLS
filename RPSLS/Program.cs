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
                game.DisplayChoice();               
                game.FindWinner();
                game.DisplayRound();
            }
            game.DeclareWinner();
            Console.WriteLine("\n" + "\n" + "Press any key to continue");
            Console.ReadLine();

        }

    }
}

