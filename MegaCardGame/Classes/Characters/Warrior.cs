using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    public class Warrior : PlayerCharacter
    {

        public Warrior() : base("Warrior", new Berserk())
        {

        }
    }
}
