using Tyuiu.MolokanovNK.Sprint1.Task2.V21.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 5;
            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(15, res);
        }
    }
}
