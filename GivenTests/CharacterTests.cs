using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Threading.Tasks;
using MegaCardGame;

namespace MegaCardGame
{
    [TestClass]
    class Character
    {
        [TestMethod]
        public void CharacterConstructor()
        {
            int maxHealth = 50;
            int currentHealth = 50;
            int baseDam = 10;

            Character testChar = new Character(50, 50, 10);

            Assert.AreEqual(testChar.maxHealthPoints, maxHealth);
            Assert.AreEqual(testChar.currentHealthPoints, currentHealth);
            Assert.AreEqual(testChar.baseDamage, baseDam);
        }



    }
}
