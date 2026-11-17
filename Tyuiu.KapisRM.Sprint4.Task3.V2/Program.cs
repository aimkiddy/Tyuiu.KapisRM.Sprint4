using System;
using Tyuiu.KapisRM.Sprint4.Task3.V2.Lib;

namespace Tyuiu.KapisRM.Sprint4.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Задание:3                                                               *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 8. Найдите максимальный     *");
            Console.WriteLine("* элемент в первой строке массива.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ЗАДАНИЕ:                                                                *");
            Console.WriteLine("* Написать программу обработки двумерного массива по условию задачи.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] arr = new int[,]
            {
                { 4, 3, 2, 8, 7 },
                { 4, 6, 5, 5, 7 },
                { 3, 8, 8, 3, 5 },
                { 5, 7, 5, 4, 4 },
                { 8, 8, 3, 7, 6 }
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

            Console.WriteLine($"Максимальный элемент в первой строке равен: {res}");
            Console.ReadKey();
        }
    }
}