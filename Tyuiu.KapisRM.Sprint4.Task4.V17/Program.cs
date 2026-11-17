using System;
using Tyuiu.KapisRM.Sprint4.Task4.V17.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Задание:4                                                               *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями в диапазоне от 2 до 7. Найдите сумму четных элементов массива.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ЗАДАНИЕ:                                                                *");
            Console.WriteLine("* Написать программу обработки двумерного массива по условию задачи.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] arr = new int[,]
            {
                { 2, 3, 2, 4, 3 },
                { 4, 7, 4, 2, 2 },
                { 5, 2, 3, 4, 6 },
                { 5, 2, 7, 6, 5 },
                { 6, 3, 5, 7, 7 }
            };

            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(arr);

            Console.WriteLine($"Сумма четных элементов массива равна: {res}");
            Console.ReadKey();
        }
    }
}