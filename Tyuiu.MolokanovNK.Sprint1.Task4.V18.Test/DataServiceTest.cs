using Tyuiu.MolokanovNK.Sprint1.Task4.V18.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.062, res);
        }
    }
}
