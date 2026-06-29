using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(-5, 10, 5)]
        [TestCase(0, 0, 0)]
        public void TestAddition(int a, int b, int expected)
        {
            int actual = calculator.Add(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Ignore("Example of Ignore Attribute")]
        [Test]
        public void IgnoreTest()
        {
            Assert.Pass();
        }
    }
}
