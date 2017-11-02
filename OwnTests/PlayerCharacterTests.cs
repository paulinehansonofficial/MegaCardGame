using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MegaCardGame;

namespace Test
{
    [TestClass]
    public class PlayerCharacterTests
    {
        [TestMethod]
        public void PlayerCharacterConstructorWarrior()
        {
            int maxHealth = 100;
            int currentHealth = 100;
            int baseDam = 10;

            Warrior gary = new Warrior();

            Assert.AreEqual(gary.maxHealthPoints, maxHealth);
            Assert.AreEqual(gary.currentHealthPoints, currentHealth);
            Assert.AreEqual(gary.baseDamage, baseDam);
        }

        [TestMethod]
        public void PlayerCharacterConstructorMage()
        {
            int maxHealth = 100;
            int currentHealth = 100;
            int baseDam = 10;

            Mage thaddius = new Mage();

            Assert.AreEqual(thaddius.maxHealthPoints, maxHealth);
            Assert.AreEqual(thaddius.currentHealthPoints, currentHealth);
            Assert.AreEqual(thaddius.baseDamage, baseDam);
        }

        [TestMethod]
        public void PlayerCharacterConstructorThief()
        {
            int maxHealth = 100;
            int currentHealth = 100;
            int baseDam = 10;

            Thief brynjolf = new Thief();

            Assert.AreEqual(brynjolf.maxHealthPoints, maxHealth);
            Assert.AreEqual(brynjolf.currentHealthPoints, currentHealth);
            Assert.AreEqual(brynjolf.baseDamage, baseDam);
        }

        [TestMethod]
        public void NormalAttackDamage()
        {
            PlayerCharacter character = new PlayerCharacter("Mage", new Fireball());

            int result = character.normalAttackDamage();

            Assert.AreEqual(result, character.baseDamage);
        }

        [TestMethod]
        public void SpecialAttackDamage()
        // will pass sometimes, just like fireball is successful sometimes
        {
            Fireball ball = new Fireball();

            int baseDamage = 10;
            int[] expectedResults = { -10, ball.attackDamageMultiplier * baseDamage };

            Assert.IsTrue(Array.IndexOf(expectedResults, ball.ReturnSpecialAttackDamage(baseDamage)) != -1);
        }

    }
}
