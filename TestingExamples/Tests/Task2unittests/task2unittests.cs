using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Task2;

namespace Task2.Tests
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
        public void Run()
        {
            Assert.Pass();
        }

    }
}
