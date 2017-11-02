using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    public class Mage : PlayerCharacter
    {
        public Mage() : base("Mage", new Fireball())  {        }
    }
}
