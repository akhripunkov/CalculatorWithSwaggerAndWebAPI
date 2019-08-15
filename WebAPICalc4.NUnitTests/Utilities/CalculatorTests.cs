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
        [TestCase(5,4,9)]
        [TestCase(5, 4, 9)]
        [TestCase(5, 60, 65)]
        [TestCase(1, 22, 23)]
        [TestCase(5000, 4333, 9333)]
        [TestCase(-274742, -200000, -474742)]
        [TestCase(1, 2, 3)]
        [TestCase(-1, -2, -3)]
        public void Add_plus_AreEqual(int a, int b, int c)
        {
            //Arrange
            var _calculator = new Calculator();

            //Act
            var result = _calculator.Add(a, b);

            //Assert
            Assert.AreEqual(result, c);
        }

        [Test]
        public void Add_5sub4_1()
        {
            //Arrange
            var _calculator = new Calculator();

            //Act
            var result = _calculator.Sub(5, 4);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Add_5mul4_20()
        {
            //Arrange
            var _calculator = new Calculator();

            //Act
            var result = _calculator.Mult(5, 4);

            //Assert
            Assert.AreEqual(result, 20);
        }

        [Test]
        public void Add_5div4_1()
        {
            //Arrange
            var _calculator = new Calculator();

            //Act
            var result = _calculator.Div(5, 4);

            //Assert
            Assert.AreEqual(result, 1);
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

        [Test]
        [TestCase("(4 + 5 + 33 + 87 + 995 * 66 - 333 / 3) / 3", 21896)]
        [TestCase("(2+       2 +     4 -2) / 3", 2)]
        [TestCase("81/9/9", 1)]
        [TestCase("42", 42)]
        public void evalexpr(string eval, int testRes)
        {
            //Arrange
            var _calculator = new Calculator();

            //Act
            var result = _calculator.Eval(eval);

            //Assert
            Assert.AreEqual(result, testRes);
        }
    }
}