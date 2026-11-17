using System;
using Tyuiu.KapisRM.Sprint4.Task2.V14.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генерация случайных элементов)                *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Задание:2                                                               *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный        *");
            Console.WriteLine("* случайными элементами в диапазоне от 1 до 8.                            *");
            Console.WriteLine("* Подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ЗАДАНИЕ:                                                                *");
            Console.WriteLine("* Написать программу обработки массива по условию задачи.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 12;
            int[] arr = new int[len];

            for (int i = 0; i < len; i++)
            {
                arr[i] = rnd.Next(1, 9);
            }

            Console.Write("Массив: [ ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr[i] + (i < len - 1 ? ", " : " "));
            }
            Console.WriteLine("]");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(arr);

            Console.WriteLine($"Произведение нечетных элементов массива равно: {res}");
            Console.ReadKey();
        }
    }
}