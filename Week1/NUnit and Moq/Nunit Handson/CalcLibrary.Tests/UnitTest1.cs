using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 7, 12)]
        [TestCase(100, 200, 300)]
        public void TestAddition(double a, double b, double expected)
        {
            double actual = calculator.Addition(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TearDown]
        public void Cleanup()
        {
            calculator.AllClear();
        }
    }
}