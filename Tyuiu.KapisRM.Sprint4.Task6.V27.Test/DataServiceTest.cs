using Tyuiu.KapisRM.Sprint4.Task6.V27.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };

            int res = ds.Calculate(array);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}