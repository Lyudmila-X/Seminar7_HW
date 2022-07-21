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
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            int strings = new Random().Next(2, 6);
            int columns = new Random().Next(2, 6);
            int[,] newArray = FillArray(strings, columns);
            PrintArray(newArray);
            Console.WriteLine();
        }
    }
}