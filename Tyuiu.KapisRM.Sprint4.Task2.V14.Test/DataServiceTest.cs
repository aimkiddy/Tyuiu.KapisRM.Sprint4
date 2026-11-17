using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint4.Task2.V14.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 3, 5, 7 };
            int res = ds.Calculate(arr);
            int wait = 1 * 3 * 5 * 7 * 1 * 3 * 5 * 7; 
            Assert.AreEqual(wait, res);
        }
    }
}