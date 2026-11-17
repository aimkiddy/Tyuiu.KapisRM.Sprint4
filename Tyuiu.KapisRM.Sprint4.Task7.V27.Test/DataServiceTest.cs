using Tyuiu.KapisRM.Sprint4.Task7.V27.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int rows = 4;
            int columns = 3;
            string value = "583197256891";

            int res = ds.Calculate(rows, columns, value);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}