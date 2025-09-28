using Tyuiu.MolokanovNK.Sprint1.Task6.V5.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string x = ("потоп дома"); 
            var res = ds.CheckSymmetricalWords(x);
            Assert.AreEqual("потоп", res);
        }
    }
}
