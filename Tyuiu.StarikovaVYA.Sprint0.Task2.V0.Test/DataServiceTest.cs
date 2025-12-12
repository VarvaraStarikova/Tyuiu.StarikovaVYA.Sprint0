using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.StarikovaVYA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.StarikovaVYA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Варвара";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Варвара", res);
        }
    }
}
