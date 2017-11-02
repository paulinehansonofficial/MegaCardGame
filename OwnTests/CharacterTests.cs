using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MegaCardGame;


namespace Tests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void CharacterConstructor()
        {
            int maxHealth = 100;
            int currentHealth = 100;
            int baseDam = 10;

            Mage testChar = new Mage();

            Assert.AreEqual(testChar.maxHealthPoints, maxHealth);
            Assert.AreEqual(testChar.currentHealthPoints, currentHealth);
            Assert.AreEqual(testChar.baseDamage, baseDam);
        }

        [TestMethod]
        public void RecieveAttack()
        {
            int result;

            Character testChar = new Character(50, 50, 10);
            testChar.recieveAttack(10);
            result = testChar.currentHealthPoints;

            Assert.AreEqual(testChar.currentHealthPoints, result);
        }

        [TestMethod]
        public void ReturnAttackDamage()
        {
            int expectedResult = 10;
            int result;

            Character testChar = new Character(50, 50, 10);

            result = testChar.returnAttackDamage();

            Assert.AreEqual(result, expectedResult);
        }


    }
}
            
