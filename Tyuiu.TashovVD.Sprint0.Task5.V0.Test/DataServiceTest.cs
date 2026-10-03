using Tyuiu.TashovVD.Sprint0.Task5.V0.Lib;

namespace Tyuiu.TashovVD.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void AdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void SubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void MultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void DivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
