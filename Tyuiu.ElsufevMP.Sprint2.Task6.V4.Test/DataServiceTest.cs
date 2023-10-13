using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint2.Task6.V4.Lib;

namespace Tyuiu.ElsufevMP.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VAlidCheck()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Пики", ds.FindCardSuit(1));
        }
    }
}
