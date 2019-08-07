using NUnit.Framework;
using System.Collections.Generic;
using WebAPICalc4.Controllers;
using WebAPICalc4.Models;
using WebAPICalc4.Utilities;

namespace Tests
{
    class ValuesControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetCalculate_Eval_NewCalculatorResult()
        {
            //Arrange
            var controller = new ValuesController();
            var res = new CalculatorResult();
            res.Div = 16;
            res.Mul = 10000;
            res.Sub = 375;
            res.Sum = 425;
            IEnumerable<CalculatorResult>  Result = new CalculatorResult[] { res };

            var result = controller.GetCalculate(400, 25);

            //Assert
            Assert.AreEqual(result.GetEnumerator(), Result.GetEnumerator());
        }

        [Test]
        public void Get_Eval2plus2mul2_6()
        {
            var controller = new ValuesController();

            var result = controller.Get("2+ 2 * 2");

            Assert.AreEqual(result, "6");
        }

        [Test]
        public void GetSum_20plus4_24()
        {
            var controller = new ValuesController();

            var result = controller.GetSum(20, 4);

            Assert.AreEqual(result, "24");
        }

        [Test]
        public void GetSub_20minus4_16()
        {
            var controller = new ValuesController();

            var result = controller.GetSub(20, 4);

            Assert.AreEqual(result, "16");
        }

        [Test]
        public void GetMul_20mul4_80()
        {
            var controller = new ValuesController();

            var result = controller.GetMul(20, 4);

            Assert.AreEqual(result, "80");
        }

        [Test]
        public void GetDiv_20div4_5()
        {
            var controller = new ValuesController();

            var result = controller.GetDiv(20, 4);

            Assert.AreEqual(result, "5");
        }
    }
}
