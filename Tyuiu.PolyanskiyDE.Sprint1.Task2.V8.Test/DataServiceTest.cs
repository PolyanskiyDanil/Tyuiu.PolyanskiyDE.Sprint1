using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint1.Task2.V8.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 3;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(10, res);
        }
    }
}
