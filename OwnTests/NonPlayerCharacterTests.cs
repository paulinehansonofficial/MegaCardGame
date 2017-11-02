using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MegaCardGame;

namespace Tests
{
    [TestClass]
    public class NonPlayerCharacterTests
    {
        [TestMethod]
        public void NonPlayerCharacterConstructor()
        {
            string[] expectedTypes = { "dragon", "goblin", "angry dwarf", "ogre", "rogue", "wizard" };
            NonPlayerCharacter testChar = new NonPlayerCharacter();
            Assert.IsTrue( Array.IndexOf(expectedTypes, testChar.enemyType) != -1);
        }

        [TestMethod]
        public void NPCRecieveAttack()
        {
            int result;

            NonPlayerCharacter testChar = new NonPlayerCharacter();
            testChar.recieveAttack(10);
            result = testChar.currentHealthPoints;

            Assert.AreEqual(testChar.currentHealthPoints, result);
        }
    }
}
