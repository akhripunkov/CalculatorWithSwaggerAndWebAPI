using NUnit.Framework;
using WebAPICalc4.Utilities;

namespace Tests
{
    public class CalculatorTests
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

        [Test]
        public void Add_IntMaxPlus1()
        {
            long    lres = (long)int.MaxValue + 1;
            long     ires;
            var _calc = new Calculator();

            ires = _calc.Add(int.MaxValue, 1);

            Assert.AreEqual(ires, lres);
        }
    }
}