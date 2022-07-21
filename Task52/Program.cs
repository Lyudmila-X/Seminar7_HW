// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using System.Collections.Generic;
using System.Linq;
namespace Seminar7
{
    class task52
    {
        public static int[,] FillArray(int str, int col)
        {
            int[,] array = new int[str, col];
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = new Random().Next(-99, 100);
                }
            }
            return array;
        }
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (Convert.ToString(array[i, j]).Length == 1)
                    {
                        Console.Write("  " + array[i, j] + " ");
                    }
                    else
                    {
                        if (Convert.ToString(array[i, j]).Length == 2)
                        {
                            Console.Write(" " + array[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(array[i, j] + " ");
                        }
                    }

                }
                Console.WriteLine();
            }
        }
        public static void AvgSumColumns(int[,] array)
        {
            double result = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    result += array[j, i];

                }
                Console.Write(Math.Round(result / array.GetLength(0), 2) + " ");
                result = 0;
            }
        }
        public static void Main(string[] args)
        {
            int strings = new Random().Next(2, 6);
            int columns = new Random().Next(2, 6);
            int[,] newArr = FillArray(strings, columns);
            Console.Clear();
            PrintArray(newArr);
            Console.WriteLine();
            AvgSumColumns(newArr);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}