using NUnit.Framework;
using Task1;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Task1.Tests
{
    [TestFixture]
    public class Tests
    {
        private Program _program;

        [SetUp]
        public void Setup()
        {
            _program = new Program();
        }

        [Test]
        public void BasicSumOperation()
        {
            // Arrange
            double val1 = 2;
            double val2 = 3;
            double expected = val1 * val2;

            // Act
            var result = _program.Calculator(val1, val2);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ThrowErrorOnZeroDenominator()
        {
            // Arrange
            double val1 = 5;
            double val2 = 0;

            // Act & Assert
            var ex = Assert.Throws<DivideByZeroException>(() =>
            {
                _program.Divider(val1, val2);
            });

            StringAssert.Contains("Attempted to divide by zero", ex.Message);
        }

    }
}