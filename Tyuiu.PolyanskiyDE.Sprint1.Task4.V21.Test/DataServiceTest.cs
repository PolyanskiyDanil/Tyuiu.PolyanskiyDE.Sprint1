using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint1.Task4.V21.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(1.750, res);
        }
    }
}
