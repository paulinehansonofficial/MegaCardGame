using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MegaCardGame;

namespace Test
{
    [TestClass]
    public class SpecialAttackTests
    {
        [TestMethod]
        public void SpecialAttackConstructor()
        {
            SpecialAttack special = new SpecialAttack(2, .5);

            int expectedValue = 2;

            Assert.AreEqual(special.attackDamageMultiplier, expectedValue);
        }

        [TestMethod]
        public void ReturnSpecialAttackDamageFireball()
        {
            Fireball ball = new Fireball();

            int baseDamage = 10;
            int[] expectedResults = { -10, ball.attackDamageMultiplier * baseDamage };

            Assert.IsTrue(Array.IndexOf(expectedResults, ball.ReturnSpecialAttackDamage(baseDamage)) != -1);
        }

        [TestMethod]
        public void ReturnSpecialAttackDamageBerserk()
        {
            Berserk berserk = new Berserk();

            int baseDamage = 10;
            int[] expectedResults = { -10, berserk.attackDamageMultiplier * baseDamage };

            Assert.IsTrue(Array.IndexOf(expectedResults, berserk.ReturnSpecialAttackDamage(baseDamage)) != -1);
        }

        [TestMethod]
        public void ReturnSpecialAttackDamageBackstab()
        {
            Backstab stabby = new Backstab();

            int baseDamage = 10;
            int[] expectedResults = { -10, stabby.attackDamageMultiplier * baseDamage };

            Assert.IsTrue(Array.IndexOf(expectedResults, stabby.ReturnSpecialAttackDamage(baseDamage)) != -1);
        }


    }
}
