using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
        }

        public override string SetInput(string name)
        {
            string input;
            ConsoleKeyInfo keyPress;
            do
            {
                Console.WriteLine($"\n{name}, please enter your input here:");
                keyPress = Console.ReadKey(true);
            } while (!(keyPress.Key == ConsoleKey.R || keyPress.Key == ConsoleKey.P || keyPress.Key == ConsoleKey.X ||
            keyPress.Key == ConsoleKey.L || keyPress.Key == ConsoleKey.S));
            if (keyPress.Key == ConsoleKey.R)
            {
                input = "rock";
            }
            else if (keyPress.Key == ConsoleKey.P)
            {
                input = "paper";
            }
            else if (keyPress.Key == ConsoleKey.X)
            {
                input = "scissors";
            }
            else if (keyPress.Key == ConsoleKey.L)
            {
                input = "lizard";
            }
            else
            {
                input = "spock";
            }
            return input;
        }
    }
}
