using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    class DummyTests
    {
        private Dummy dummy;
        private int health = 2;
        private int damage = 1;
        private int expireance = 2;


        [SetUp]
        public void SetUp()
        {
            dummy = new Dummy(2, 2);
        }

        [Test]
        public void DummyLossesHealthWhenAttacked()
        {
            damage = 1;
            dummy.TakeAttack(damage);

            Assert.AreEqual(health - damage, dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsExeptionWhenAttacked()
        {
            damage = 2;
            dummy.TakeAttack(damage);

            var ex = Assert.Throws<InvalidOperationException>(
                () =>
                {
                    dummy.TakeAttack(damage);
                });

            Assert.AreEqual("Dummy is dead.", ex.Message);

        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            damage = 3;
            dummy.TakeAttack(damage);

            Assert.AreEqual(expireance , dummy.GiveExperience());

        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            damage = 1;

            var ex = Assert.Throws<InvalidOperationException>(
                () =>
                {
                    dummy.GiveExperience();
                });

            Assert.AreEqual("Target is not dead.", ex.Message);
        }
    }
}
