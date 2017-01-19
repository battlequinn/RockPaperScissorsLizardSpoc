using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Multiplayer
    {
        private void DisplayRules()
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Multiplayer");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("\nr = rock \np = paper \nx = scissors \nl = lizzard \ns = spock");
        }
        private void PassToPlayerOne()
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Please pass the device to Player 1.");
            Console.WriteLine("=======================================================================================");
        }
        private void PassToPlayerTwo()
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Please pass the device to Player 2.");
            Console.WriteLine("=======================================================================================");
        }
        private string SetPlayerInput()
        {
            string input;
            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("\nEnter your input here:");
                cki = Console.ReadKey(true);
            } while (!(cki.Key == ConsoleKey.R || cki.Key == ConsoleKey.P || cki.Key == ConsoleKey.X ||
            cki.Key == ConsoleKey.L || cki.Key == ConsoleKey.S));
            if(cki.Key == ConsoleKey.R)
            {
                input = "rock";
            }else if(cki.Key == ConsoleKey.P)
            {
                input = "paper";
            }else if(cki.Key == ConsoleKey.X)
            {
                input = "scissors";
            }else if(cki.Key == ConsoleKey.L)
            {
                input = "lizzard";
            }else
            {
                input = "spock";
            }
            return input;
        }
        private string GetPlayerOneInput()
        {
            PassToPlayerOne();
            string playerOneInput = SetPlayerInput();
            return playerOneInput;
        }
            private string GetPlayerTwoInput()
        {
            PassToPlayerTwo();
            string playerTwoInput = SetPlayerInput();
            return playerTwoInput;
        }private void CompareInputs()
        {
            string inputOne = GetPlayerOneInput();
            string inputTwo = GetPlayerTwoInput();
            Console.WriteLine($"Player One: {inputOne}");
            Console.WriteLine($"Player Two: {inputTwo}");
            
        }
        public void RunMultiplayer()
        {
            DisplayRules();
            CompareInputs();
        }
    }
}
