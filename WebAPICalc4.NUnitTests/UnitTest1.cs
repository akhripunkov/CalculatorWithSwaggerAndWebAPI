using NUnit.Framework;
using WebAPICalc4.Utilities;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_5plus4_9()
        {
            //Arrange
            var _calculator = new Calculator();

            //Act
            var result = _calculator.Add(5, 4);

            //Assert
            Assert.AreEqual(result, 9);
        }
    }
}