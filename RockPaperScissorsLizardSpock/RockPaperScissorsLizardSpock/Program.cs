using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsLizardSpock Spock = new RockPaperScissorsLizardSpock();
            Multiplayer multiplayer = new Multiplayer();
            Singleplayer singleplayer = new Singleplayer();
            Spock.DisplayWelcome();
            int mode = Spock.ChooseGameMode();
            if(mode == 1){
                singleplayer.RunSingleplayer();
            }
            else
            {
                multiplayer.RunMultiplayer();
            }
            Console.ReadKey();
        }
    }
}
