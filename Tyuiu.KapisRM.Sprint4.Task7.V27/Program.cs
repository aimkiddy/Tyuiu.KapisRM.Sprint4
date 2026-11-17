using Tyuiu.KapisRM.Sprint4.Task7.V27.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Задание:7                                                               *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"583197256891\". Преобразуйте ее     *");
            Console.WriteLine("* в матрицу 4 на 3 и подсчитайте количество четных чисел.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ЗАДАНИЕ:                                                                *");
            Console.WriteLine("* Написать программу обработки двумерного массива по условию задачи.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int rows = 4;
            int columns = 3;
            string value = "583197256891";

            Console.WriteLine("Строка: " + value);
            Console.WriteLine("Матрица:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{value[i * columns + j],3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, columns, value);
            Console.WriteLine("Количество четных чисел = " + res);
            Console.ReadKey();
        }
    }
}