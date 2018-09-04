using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class Class1
    {
        Dummy dummy;
        private int durability = 10;

        [SetUp]
        public void SetUp()
        {
            dummy = new Dummy(10, 10);
        }

        [Test]
        public void AxeLossesDurabilityAfterAttack()
        {
            var axe = new Axe(10, durability);
            axe.Attack(dummy);

            Assert.AreEqual(durability - 1, axe.DurabilityPoints);
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            var axe = new Axe(10, 1);
            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(
                () =>
                {
                    axe.Attack(dummy);
                });

            Assert.AreEqual("Axe is broken.", ex.Message);
        }
    }
}
