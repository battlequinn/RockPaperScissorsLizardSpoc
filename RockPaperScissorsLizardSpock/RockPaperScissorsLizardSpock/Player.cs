using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        public string name;
        public Player()
        {
        }
        public virtual string SetInput(string name)
        {
            return name;
        }
    }
}
