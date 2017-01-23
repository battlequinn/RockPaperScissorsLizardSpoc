using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Computer : Player
    {
        public Computer(string name)
        {
            this.name = name;
        }
        public override string SetInput(string name)
        {
            string input = "";
            int result;
            Random random = new Random();
            result = random.Next(0, 5);
            Console.WriteLine(result);
            switch (result)
            {
                case 0:
                    input = "rock";
                    break;
                case 1:
                    input = "paper";
                    break;
                case 2:
                    input = "scissors";
                    break;
                case 3:
                    input = "spock";
                    break;
                case 4:
                    input = "lizard";
                    break;
                default:
                    Console.WriteLine("ERROR: Could not process request.");
                    break;
            }
            return input;
        }
    }
}
