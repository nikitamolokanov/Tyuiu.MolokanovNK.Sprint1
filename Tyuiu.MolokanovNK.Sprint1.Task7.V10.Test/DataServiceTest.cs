﻿using Tyuiu.MolokanovNK.Sprint1.Task7.V10.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(-13.142, res);
        }
    }
}
