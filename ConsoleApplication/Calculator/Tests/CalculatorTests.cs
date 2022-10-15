using NUnit.Framework;

namespace Proxor
{
    public sealed class CalculatorTests
    {
        [Test]
        public void TestSquareEquation()
        {
            var calculator = new Calculator(new CalculatorHistory());

            var actualX1 = calculator.SquareEquation(3, 7, -10);
            var expectedX1 = 1;

            Assert.AreEqual(expectedX1, actualX1);
        }
    }
}