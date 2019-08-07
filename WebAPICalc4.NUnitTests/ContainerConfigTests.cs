using NUnit.Framework;
using WebAPICalc4;

namespace Tests
{
    class ContainerConfigTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Configure_ContainerIsNotNull()
        {
            //Arrange
            //Act
             var _cont = ContainerConfig.Configure();
            //Assert
            Assert.IsNotNull(_cont);
        }
    }
}
