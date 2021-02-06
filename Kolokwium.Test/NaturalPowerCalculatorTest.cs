using NUnit.Framework;
using Kolokwium;

namespace Kolokwium.Test
{
    class NaturalPowerCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test2Power2_ShouldReturn4()
        {
            var power = new NaturalPowerCalculator();
            var result = power.Calculate(2, 2);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test2Power3_ShouldReturn8()
        {
            var power = new NaturalPowerCalculator();
            var result = power.Calculate(2, 3);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void Test2Power4_ShouldReturn16()
        {
            var power = new NaturalPowerCalculator();
            var result = power.Calculate(2, 4);

            Assert.AreEqual(16, result);
        }

        [Test]
        public void Test2Power1_ShouldReturn2()
        {
            var power = new NaturalPowerCalculator();
            var result = power.Calculate(2, 1);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test2Power0_ShouldReturn1()
        {
            var power = new NaturalPowerCalculator();
            var result = power.Calculate(2, 1);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestMinus2Power2_ShouldReturn0()
        {
            var power = new NaturalPowerCalculator();
            var result = power.Calculate(-2, 2);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test2PowerMinus2_ShouldReturn0()
        {
            var power = new NaturalPowerCalculator();
            var result = power.Calculate(2, -2);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMinus2PowerMinus2_ShouldReturn0()
        {
            var power = new NaturalPowerCalculator();
            var result = power.Calculate(-2, -2);

            Assert.AreEqual(0, result);
        }
    }
}
