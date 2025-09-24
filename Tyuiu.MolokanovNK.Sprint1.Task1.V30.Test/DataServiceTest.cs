using Tyuiu.MolokanovNK.Sprint1.Task1.V30.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }
    }
}
