using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Game
    {
        // member variables
        public Player playerOne;
        public Player playerTwo;
        // public Player player;
        public string userAnswer;
        public string result;

        // constructor
        public Game()
        {
            playerOne = new Human();
            DisplayRules();
            DeterminePlayerTwo();
            //playerTwo.ChooseChoice();
        }
        // member methods
        public void RunGame()
        {

            //DisplayRules();
            GettingPlayerChoices();
            CompareChoice();
            DisplayScore();
            DetermineWinner();
        }

        public void DetermineWinner()
        {
            if (playerOne.score < 2 && playerTwo.score < 2)
            {
                RunGame();
            }
            else if(playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + " won " + playerOne.score + " out of 3 rounds. "  + playerOne.name + " wins the game!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " won " + playerTwo.score + " out of 3 rounds. "  + playerTwo.name + " wins the game!");
            }
        }
        public void DisplayScore()
        {
            Console.WriteLine(playerOne.name + " currently has a score of " + playerOne.score + ".");
            Console.WriteLine(playerTwo.name + " currently has a score of " + playerTwo.score + ".");
        }

        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules for Rock, Paper, Scissors, Lizard, and Spock: \n");
            Console.WriteLine("Scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock");
            Console.WriteLine("Spock smashes scissors, scissors decapitates lizard, lizard eats paper, paper disproves Spock");
            Console.WriteLine("Spock vaporizes rock, and as it always has, rock crushes scissors. \n");
            Console.WriteLine("The winner is determined by winning 2 out of 3 rounds. \n");
            Console.WriteLine("Now that you are familiar with the rules let's play! \n");
        }

        public void GettingPlayerChoices()
        {
            playerOne.ChooseChoice();
            playerTwo.ChooseChoice();
        }

        public void IncrementPlayerScore(Player player)
        {
            player.score++;
        }

        public void DeterminePlayerTwo()
        {
            Console.WriteLine("Would you like to play against a computer or another player?");
            userAnswer = Console.ReadLine();
            Console.Clear();

            if(userAnswer == "player")
            {
                Console.WriteLine("Hello Player 2!");
                playerTwo = new Human();
                // Console.Write("Player two choose either rock, paper, scissors, lizards, or spock.");
            }
            else
            {
                playerTwo = new AI();
                
            }
        }

            public void CompareChoice()
        {
            bool? playerOneIsWinner = true;
            if (playerOne.choice == playerTwo.choice)
            {
                result = "Tie";
                Console.WriteLine("You both tied. Play again!");
                playerOneIsWinner = null;
            }
            else if (playerOne.choice == "rock")
            {
                if (playerTwo.choice == "scissors")
                {
                    Console.WriteLine("Rock crushes scissors. You win!");
                }
                else if (playerTwo.choice == "lizard")
                {
                    Console.WriteLine("Rock crushes lizard. You win!");
                }
                else if (playerTwo.choice == "spock")
                {
                    Console.WriteLine("Spock vaporizes rock. You lose!");
                    playerOneIsWinner = false;
                }
                else
                {
                    Console.WriteLine("Paper covers rock. You lose!");
                    playerOneIsWinner = false;
                }
            }
            else if (playerOne.choice == "paper")
            {
                if (playerTwo.choice == "rock")
                {
                    Console.WriteLine("Paper covers rock. You win!");
                }
                else if (playerTwo.choice == "spock")
                {
                    Console.WriteLine("Paper disproves spock. You win!");
                }
                else if (playerTwo.choice == "lizard") 
                {
                    Console.WriteLine("Lizard eats paper. You lose!");
                    playerOneIsWinner = false;
                }
                else
                {
                    Console.WriteLine("Scissors cuts paper. You lose!");
                    playerOneIsWinner = false;
                }
            }
            else if (playerOne.choice == "scissors")
            {
                if (playerTwo.choice == "paper")
                {
                    Console.WriteLine("Scissors cuts paper. You win!");
                }
                else if (playerTwo.choice == "lizard")
                {
                    Console.WriteLine("Scissors decapitates lizard. You win!");
                }
                else if (playerTwo.choice == "spock")
                {
                    Console.WriteLine("Spock smashes scissors. You lose!");
                    playerOneIsWinner = false;
                }
                else
                {
                    Console.WriteLine("Rock crushes scissors. You lose!");
                    playerOneIsWinner = false;
                }
            }
            else if (playerOne.choice == "lizard")
            {
                if (playerTwo.choice == "spock")
                {
                    Console.WriteLine("Lizard poisons spock. You win!");
                }
                else if (playerTwo.choice == "paper")
                {
                    Console.WriteLine("Paper disproves spock. You win!");
                }
                else if (playerTwo.choice == "rock")
                {
                    Console.WriteLine("Rock crushes lizard. You lose!");
                    playerOneIsWinner = false;
                }
                else
                {
                    Console.WriteLine("Scissors cuts lizard. You lose!");
                    playerOneIsWinner = false;
                }
            }
            else if (playerOne.choice == "spock")
            {
                if (playerTwo.choice == "scissors")
                {
                    Console.WriteLine("Spock smashes scissors. You win!");
                }
                else if (playerTwo.choice == "rock")
                {
                    Console.WriteLine("Spock vaporizes rock. You win!");
                }
                else if (playerTwo.choice == "lizard")
                {
                    Console.WriteLine("Lizard poisons spock. You lose!");
                    playerOneIsWinner = false;
                }
                else
                {
                    Console.WriteLine("Paper disproves spock. You lose!");
                    playerOneIsWinner = false;
                }
            }

            if (playerOneIsWinner == true)
            {
                IncrementPlayerScore(playerOne);
            }
            else if (playerOneIsWinner == false)
            {
                IncrementPlayerScore(playerTwo);
            }          

        }
    }
}
