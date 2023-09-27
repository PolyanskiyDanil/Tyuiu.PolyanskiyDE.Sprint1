using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint1.Task5.V7.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 239.999;
            f = f - f % 30;
            DataService ds = new DataService();
            var res = ds.AngleToHoursMinutes(f);

            Assert.AreEqual(7, res);
        }
    }
}
