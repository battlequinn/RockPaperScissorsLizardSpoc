using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public List<Player> players;
        public List<string> inputs;

        public Game()
        {
            players = new List<Player>();
            inputs = new List<string>();
        }
        public void AddPeople()
        {
            Console.WriteLine("Please enter your name: ");
            string player = Console.ReadLine();
            players.Add(new Human(player));
        }
        public void AddComputer()
        {
            players.Add(new Computer("Computer"));
        }

        private void DisplayWelcome()
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Welcome to Rock Paper Scisors Lizard Spock!");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("The rules are simple:\n");
            Console.WriteLine("Scissors cuts Paper \nPaper covers Rock");
            Console.WriteLine("Rock crushes Lizard \nLizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors \nScissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper \nPaper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock \nand as it always has");
            Console.WriteLine("Rock crushes Scissors\n\n");
            Console.WriteLine("You will be playing best two out of three.");
            Console.WriteLine("=======================================================================================");
        }
        private int ChooseGameMode()
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("___________");
            Console.WriteLine("\nPlease enter the number corresponding to the game mode you would like to play.");
            bool loop = false;
            int answer;
            do
            {
                Console.WriteLine("\n1) Singleplayer -1vComputer \n2) Multiplayer -1v1 \n3) Quit");
                bool result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2 || answer == 3))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("ERROR: Unable to read input. Please type the number '1', '2', or '3'.");
                    loop = true;
                }
            } while (loop == true);
            return answer;
        }
        private void DisplayGameMode(int mode)
        {
            Console.WriteLine("=======================================================================================");
            if(mode == 1)
            {
                Console.WriteLine("Singleplayer");
            }else
            {
                Console.WriteLine("Multiplayer");
            }
            Console.WriteLine("=======================================================================================");
        }

        private void DisplayRules()
        {
            Console.WriteLine("\nr = rock \np = paper \nx = scissors \nl = lizard \ns = spock\n");
        }

        private void DisplayPass()
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Please pass the device to Player 2.");
            Console.WriteLine("=======================================================================================");
        }
        
        private void DisplayInputs(string inputOne, string inputTwo)
        {
            Console.WriteLine($"{players[0].name}: {inputOne}\n{players[1].name}: {inputTwo}");
        }
        private int AssignNumberToInput(string input)
        {
            int inputAsNumber = 0;
            switch(input)
            {
                case "rock":
                    inputAsNumber = 0;
                    break;
                case "paper":
                    inputAsNumber = 1;
                    break;
                case "scissors":
                    inputAsNumber = 2;
                    break;
                case "spock":
                    inputAsNumber = 3;
                        break;
                case "lizard":
                    inputAsNumber = 4;
                    break;
                default:
                    Console.WriteLine("ERROR: Could not process request.");
                    break;
            }
            return inputAsNumber;
        }
        private int DetermineWinner(string inputOne, string inputTwo)
        {
            int playerWhoWon = 0;
            int inputOneNumber = AssignNumberToInput(inputOne);
            int inputTwoNumber = AssignNumberToInput(inputTwo);
            int outcome = (5 + inputOneNumber - inputTwoNumber) % 5;
            if (outcome == 1 || outcome == 3)
            {
                return playerWhoWon = 1;
            }
            else if (outcome == 2 || outcome == 4)
            {
                return playerWhoWon = 2;
            }else
            {
                return playerWhoWon = 0;
            }
            
        }
        private void DisplayRoundWinner(int playerWhoWon)
        {
            switch (playerWhoWon)
            {
                case 0:
                    Console.WriteLine("Tie.");
                    break;
                case 1:
                    Console.WriteLine($"{players[0].name} wins the round.");
                    break;
                case 2:
                    Console.WriteLine($"{players[1].name} wins the round.");
                    break;
                default:
                    Console.WriteLine("ERROR: Could not process request.");
                    break;
            }
        }
        private void PlayNextRound(int playerWhoWon, int playerOneWin, int playerTwoWin, int mode)
        {
            if (playerWhoWon == 1)
            {
                playerOneWin++;
            }
            else if (playerWhoWon == 2)
            {
                playerTwoWin++;
            }
            if(playerOneWin < 2 && playerTwoWin < 2)
            {
                PlayRound(playerOneWin, playerTwoWin, mode);
            }else
            {
                DisplayWinCount(playerOneWin, playerTwoWin);
                DisplayGameWinner(playerOneWin, playerTwoWin);
            }
        }
        private void DisplayWinCount(int playerOneWin, int PlayerTwoWin)
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine($"{players[0].name} Wins: {playerOneWin} \n{players[1].name} Wins: {PlayerTwoWin}");
            Console.WriteLine("=======================================================================================");
        }

        private void DisplayGameWinner(int playerOneWin, int playerTwoWin)
        {
            if (playerOneWin >= 2 || playerTwoWin >= 2)
            {
                Console.WriteLine("\n=======================================================================================");
                if (playerOneWin == 2)
                {
                    Console.WriteLine($"{players[0].name} wins!");
                }
                else
                {
                    Console.WriteLine($"{players[1].name} wins!");
                }
                Console.WriteLine("=======================================================================================");
            }
        }

        private void RestartGame()
        {
            bool loop = false;
            int answer;
            do
            {
                Console.WriteLine("\nWould you like to restart? \n1)Yes \n2)No");
                bool result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("ERROR: Unable to read input. Please type the number '1' or '2'.");
                    loop = true;
                }
            } while (loop == true);
            if (answer == 1)
            {
                inputs.Clear();
                players.Clear();
                RunGame();
            }
        }
        private void GetInputs()
        {
            inputs.Add(players[0].SetInput(players[0].name));
            inputs.Add(players[1].SetInput(players[1].name));
        }

        private void PlayRound(int playerOneWin, int playerTwoWin, int mode)
        {
            DisplayGameMode(mode);
            DisplayRules();
            DisplayWinCount(playerOneWin, playerTwoWin);
            GetInputs();
            DisplayInputs(inputs[0], inputs[1]);
            int playerWhoWon = DetermineWinner(inputs[0], inputs[1]);
            DisplayRoundWinner(playerWhoWon);
            Console.ReadKey();
            Console.Clear();
            inputs.Clear();
            PlayNextRound(playerWhoWon, playerOneWin, playerTwoWin, mode);
        }
        public void RunGame()
        {
            Console.Clear();
            DisplayWelcome();
            int mode = ChooseGameMode();
            switch (mode)
            {
                case 1:
                    AddPeople();
                    AddComputer();
                    break;
                case 2:
                    AddPeople();
                    DisplayPass();
                    AddPeople();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Sorry, there was an error processing your request.");
                    break;
            }
            Console.Clear();
            int playerOneWin = 0;
            int playerTwoWin = 0;
            PlayRound(playerOneWin, playerTwoWin, mode);
            RestartGame();
        }
    }
}
