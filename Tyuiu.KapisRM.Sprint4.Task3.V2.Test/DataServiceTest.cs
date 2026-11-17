using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint4.Task3.V2.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] arr = new int[,]
            {
                { 4, 3, 2, 8, 7 },
                { 4, 6, 5, 5, 7 },
                { 3, 8, 8, 3, 5 },
                { 5, 7, 5, 4, 4 },
                { 8, 8, 3, 7, 6 }
            };
            int res = ds.Calculate(arr);
            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}