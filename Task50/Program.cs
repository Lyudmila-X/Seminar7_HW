// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

namespace Seminar7
{
    class Rpogram
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
        public static void NumOutput(int[,] incomeArray, int indexStr, int indexCol)
        {
            try
            {
                int result = incomeArray[indexStr, indexCol];
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("такого числа в массиве нет");
            }
        }
        public static void Main()
        {
            Console.Clear();
            Console.Write("Размер массива задать произвольно? выберите да или нет, нажав клавиши y или n: ");
            string answer = Console.ReadLine()!;
            int strings = new int();
            int columns = new int();
            if (answer == "y")
            {
                strings = new Random().Next(2, 6);
                columns = new Random().Next(2, 6);
            }
            else
            {
                Console.WriteLine("Введите размер массива ");
                Console.Write("Количество строк: ");
                strings = Convert.ToInt32(Console.ReadLine());
                Console.Write("Количество столбцов: ");
                columns = Convert.ToInt32(Console.ReadLine());
            }
            int[,] newArray = FillArray(strings, columns);
            PrintArray(newArray);
            Console.WriteLine("Введите позиции элемента, который хотите посмотреть:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Обратите внимание, индекс отсчитывается с 0:");
            Console.ResetColor();
            Console.Write("Индекс строки: ");
            int strIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write("Индекс столбца: ");
            int colIndex = Convert.ToInt32(Console.ReadLine());
            NumOutput(newArray, strIndex, colIndex);
            Console.ReadKey();
        }
    }
}