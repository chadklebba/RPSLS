using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPSLS
{
    class Game
    {
        
        public Player playerOne;
        public Player playerTwo;
        public string playerOneChoice;
        public string playerTwoChoice;

        public Game()
        {
            
        }

        public void DisplayChoice()
        {
            string one = playerOne.playerChoice;
            string two = playerTwo.playerChoice;
            Console.Clear();
            Console.WriteLine(playerOne.playerName + " chose " + playerOne.playerChoice + "\r");
            Console.WriteLine(playerTwo.playerName + " chose " + playerTwo.playerChoice + "\n");
            if((one == "Scissors" | two == "Scissors") & (one == "Paper" | two == "Paper"))
            {
                Console.WriteLine("Scissors cuts Paper" + "\n");
            }
            if ((one == "Paper" | two == "Paper") & (one == "Rock" | two == "Rock"))
            {
                Console.WriteLine("Paper covers Rock" + "\n");
            }
            if ((one == "Rock" | two == "Rock") & (one == "Lizard" | two == "Lizard"))
            {
                Console.WriteLine("Rock crushes Lizard" + "\n");
            }
            if ((one == "Lizard" | two == "Lizard") & (one == "Spock" | two == "Spock"))
            {
                Console.WriteLine("Lizard poisons Spock" + "\n");
            }
            if ((one == "Spock" | two == "Spock") & (one == "Scissors" | two == "Scissors"))
            {
                Console.WriteLine("Spock smashes Scissors" + "\n");
            }
            if ((one == "Scissors" | two == "Scissors") & (one == "Lizard" | two == "Lizard"))
            {
                Console.WriteLine("Scissors decapitates Lizard" + "\n");
            }
            if ((one == "Lizard" | two == "Lizard") & (one == "Paper" | two == "Paper"))
            {
                Console.WriteLine("Lizard eats Paper" + "\n");
            }
            if ((one == "Paper" | two == "Paper") & (one == "Spock" | two == "Spock"))
            {
                Console.WriteLine("Paper disproves Spock" + "\n");
            }
            if ((one == "Spock" | two == "Spock") & (one == "Rock" | two == "Rock"))
            {
                Console.WriteLine("Spock vaporizes Rock" + "\n");
            }
            if ((one == "Rock" | two == "Rock") & (one == "Scissors" | two == "Scissors"))
            {
                Console.WriteLine("Rock crushes Scissors" + "\n");
            }
        }
        public void DisplayRound()
        {
            Console.Clear();
            Console.WriteLine("At the end of the round, the score is:");
            Console.WriteLine(playerOne.playerName + " has " + playerOne.playerScore + " win(s)" + "\r");
            Console.WriteLine(playerTwo.playerName + " has " + playerTwo.playerScore + " win(s)");
            Console.WriteLine("\n"+"\n"+"Press any key to continue");
            Console.ReadLine();
        }

        public void DisplayInstruction()
        {
            string rpsls = "Rock Paper Scissors Lizard Spock";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (rpsls.Length / 2)) + "}", rpsls) + "\n");
            Console.ResetColor();
            Console.WriteLine("The game is an expansion on the game Rock, Paper, Scissors. Each player picks a variable and reveals it at the same time. The winner is the one who defeats the others. In a tie, the process is repeated until a winner is found." + "\n");
            Console.WriteLine("Scissors cuts Paper" + "\r");
            Console.WriteLine("Paper covers Rock" + "\r");
            Console.WriteLine("Rock crushes Lizard" + "\r");
            Console.WriteLine("Lizard poisons Spock" + "\r");
            Console.WriteLine("Spock smashes Scissors" + "\r");
            Console.WriteLine("Scissors decapitates Lizard" + "\r");
            Console.WriteLine("Lizard eats Paper" + "\r");
            Console.WriteLine("Paper disproves Spock" + "\r");
            Console.WriteLine("Spock vaporizes Rock" + "\r");
            Console.WriteLine("(and as it always has) Rock crushes Scissors"+"\n");
            Console.WriteLine("This match will be best 2 out of 3" + "\n");
            Console.WriteLine("For a video tutorial hit (v), otherwise hit any other key to continue");
            ConsoleKeyInfo answer;
            answer = Console.ReadKey();
            switch (answer.Key)
            {
                case ConsoleKey.V:
                    try
                    {
                        System.Diagnostics.Process.Start("https://youtu.be/cSLeBKT7-sM");
                    }
                    catch { }
                    break;
                default:
                    break;
            }
                
        }
        public void Turn()
        {
            Console.Clear();
            Console.WriteLine(playerOne.playerName + " ");
            playerOne.PlayerChoose();
            Console.Clear();
            Console.WriteLine(playerTwo.playerName + " ");
            playerTwo.PlayerChoose();
            playerOneChoice = playerOne.playerChoice;
            playerTwoChoice = playerTwo.playerChoice;
        }
        public void ChoosePlayers()
            {
                Console.Clear();
                Console.WriteLine("How would you like to set up this game?" + "\n");
                Console.WriteLine("(1) Human against Human" + "\r");
                Console.WriteLine("(2) Human against Computer");
                string playerSelection = Console.ReadLine();
                switch (playerSelection)
                {
                    case "1":
                        Console.Clear();
                        playerOne = new Human();
                        playerTwo = new Human();
                        Console.WriteLine("Player one, what is your name?");
                        playerOne.PlayerName();
                        Console.Clear();
                        Console.WriteLine("Player two, what is your name?");
                        playerTwo.PlayerName();
                        break;
                    case "2":
                        Console.Clear();
                        playerOne = new Human();
                        playerTwo = new Computer();
                        Console.WriteLine("Player one, what is your name?");
                        playerOne.PlayerName();
                        Console.Clear();
                        Console.WriteLine("You will be playing against " + playerTwo.playerName);
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please select either 1 or 2");
                        Console.ReadLine();
                        ChoosePlayers();
                        break;
                }
            }
                 
           public void DeclareWinner()
            {
                if (playerOne.playerScore == 2)
                {
                    Console.Clear();
                    Console.WriteLine(playerOne.playerName + " wins the match!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(playerTwo.playerName + " wins the match!");
                }
            }

            public void FindWinner()
            {
                switch (playerOneChoice)
                {
                    case "Rock":
                        if (playerTwoChoice == "Rock")
                        {
                            Console.WriteLine("Tie!");
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else if (playerTwoChoice == "Scissors" | playerTwoChoice == "Lizard")
                        {
                            Console.WriteLine(playerOne.playerName + " wins the round!");
                            playerOne.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(playerTwo.playerName + " wins the round!");
                            playerTwo.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        break;
                    case "Scissors":
                        if (playerTwoChoice == "Scissors")
                        {
                            Console.WriteLine("Tie!");
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else if (playerTwoChoice == "Paper" | playerTwoChoice == "Lizard")
                        {
                        Console.WriteLine(playerOne.playerName + " wins the round!");
                        playerOne.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else
                        {
                        Console.WriteLine(playerTwo.playerName + " wins the round!");
                        playerTwo.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        break;
                    case "Paper":
                        if (playerTwoChoice == "Paper")
                        {
                            Console.WriteLine("Tie!");
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else if (playerTwoChoice == "Rock" | playerTwoChoice == "Spock")
                        {
                        Console.WriteLine(playerOne.playerName + " wins the round!");
                        playerOne.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else
                        {
                        Console.WriteLine(playerTwo.playerName + " wins the round!");
                        playerTwo.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        break;
                    case "Lizard":
                        if (playerTwoChoice == "Lizard")
                        {
                            Console.WriteLine("Tie!");
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else if (playerTwoChoice == "Spock" | playerTwoChoice == "Paper")
                        {
                        Console.WriteLine(playerOne.playerName + " wins the round!");
                        playerOne.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else
                        {
                        Console.WriteLine(playerTwo.playerName + " wins the round!");
                        playerTwo.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        break;
                    case "Spock":
                        if (playerTwoChoice == "Spock")
                        {
                            Console.WriteLine("Tie!");
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else if (playerTwoChoice == "Scissors" | playerTwoChoice == "Rock")
                        {
                        Console.WriteLine(playerOne.playerName + " wins the round!");
                        playerOne.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        else
                        {
                        Console.WriteLine(playerTwo.playerName + " wins the round!");
                        playerTwo.playerScore += 1;
                        Console.WriteLine("\n" + "\n" + "Press any key to continue");
                        Console.ReadLine();
                        }
                        break;
                }
            }
        }
    }
