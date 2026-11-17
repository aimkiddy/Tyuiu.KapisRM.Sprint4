using Tyuiu.KapisRM.Sprint4.Task6.V27.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Задание:6                                                               *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Квадрат\", \"Прямоугольник\", \"Круг\",      *");
            Console.WriteLine("* \"Треугольник\", \"Пятиугольник\", \"Шестиугольник\", \"Восьмиугольник\"]    *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина которых   *");
            Console.WriteLine("* меньше 7.                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ЗАДАНИЕ:                                                                *");
            Console.WriteLine("* Написать программу обработки массива по условию задачи.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string[] array = { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };

            Console.WriteLine("Массив: " + string.Join(", ", array));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine("Количество элементов, длина которых меньше 7 = " + res);
            Console.ReadKey();
        }
    }
}   