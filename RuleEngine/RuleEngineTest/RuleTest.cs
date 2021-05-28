using NUnit.Framework;
using RuleEngine;
using System;

namespace RuleEngineTest
{
    [TestFixture]
    public class RuleTest
    {
        [Test]
        public void testPromotionObject()
        {
            Promotion promotion = new Promotion();
            Assert.IsNotNull(promotion);
        }
    }
}
