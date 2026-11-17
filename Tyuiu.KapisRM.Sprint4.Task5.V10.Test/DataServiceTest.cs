using Tyuiu.KapisRM.Sprint4.Task5.V10.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5]
            {
                {  1, -4,  7,  0,  3 },
                { -2,  5, -1,  6, -3 },
                {  4,  0, -4,  2,  7 },
                { -1,  3,  1, -2,  0 },
                {  6, -3,  2,  5, -4 }
            };

            int res = ds.Calculate(mtrx);
            int wait = 52;
            Assert.AreEqual(wait, res);
        }
    }
}