using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Moq;

namespace Skeleton.Tests
{
    [TestFixture]
    class HeroTest
    {
        [Test]
        public void HeroCanTakeXP()
        {
            int attack = 10;
            int durability = 10;
            int enemyXP = 10;
            int enemyHealth = 3;

            IWeapon axe = new FakeWeapon();
            ITarget target = new FakeTarget();
            Hero hero = new Hero("Stamat", axe);

            hero.Attack(target);

            Assert.That(hero.Experience, Is.EqualTo(target.GiveExperience()));
        }

        [Test]
        public void HeroCanTakeXPWithMock()
        {
            var weapon = new Mock<IWeapon>();
            var target = new Mock<ITarget>();

            target.Setup(t => t.IsDead()).Returns(true);
            target.Setup(t => t.Health).Returns(0);
            target.Setup(t => t.GiveExperience()).Returns(20);

            Hero hero = new Hero("Stamat", weapon.Object);

            hero.Attack(target.Object);


            Assert.That(hero.Experience, Is.EqualTo(target.Object.GiveExperience()));
        }
    }
}
