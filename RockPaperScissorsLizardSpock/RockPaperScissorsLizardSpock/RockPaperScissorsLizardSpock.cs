using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class RockPaperScissorsLizardSpock
    {
        public void DisplayWelcome()
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
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("=======================================================================================");
        }
        public int ChooseGameMode()
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("___________");
            Console.WriteLine("\nPlease enter the number corresponding to the game mode you would like to play.");
            bool reset = false;
            int answer;
            do
            {
                Console.WriteLine("\n1) Singleplayer\n2) Multiplayer");
                bool result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR: Unable to read input. Please type the number '1' or '2'.");
                    reset = true;
                }
            } while (reset == true);
            return answer;
        }


    }
}
