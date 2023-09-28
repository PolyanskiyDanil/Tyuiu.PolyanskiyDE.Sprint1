using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint1.Task6.V3.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string value = "Тюменский Индустриальный Университет";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(value);
            string wait = "ййт";
            Assert.AreEqual(wait, res);
        }
    }
}
