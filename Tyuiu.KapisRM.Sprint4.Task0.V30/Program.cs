using System;
using Tyuiu.KapisRM.Sprint4.Task0.V30.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномернырные массивы (статичный ввод)                            *");
            Console.WriteLine("* Задание:0                                                               *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму         *");
            Console.WriteLine("* четных элементов массива. {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arr = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            Console.Write("Массив: [ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : " "));
            }
            Console.WriteLine("]");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumEvenArrEl(arr);

            Console.WriteLine($"Сумма четных элементов массива равна: {res}");
            Console.ReadKey();
        }
    }
}