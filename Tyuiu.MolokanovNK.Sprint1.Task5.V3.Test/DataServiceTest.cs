using Tyuiu.MolokanovNK.Sprint1.Task5.V3.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 435632;

            var res = ds.Calculate(k);
            int result = Convert.ToInt32(res);
            int wait = 1;
            Assert.AreEqual(6, res);
        }
    }
}
