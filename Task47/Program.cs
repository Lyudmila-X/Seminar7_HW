// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
namespace Seminar7
{
    class Program
    {
        public static double[,] FillArray(int str, int col)
        {
            double[,] array = new double[str, col];
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int coin = new Random().Next(0, 2);
                    if (coin == 0)
                    {
                        array[i, j] = Math.Round(new Random().Next(-99, 100) + new Random().NextDouble(), 2);
                    }
                    else
                    {
                        array[i, j] = new Random().Next(-99, 100);
                    }

                }
            }
            return array;
        }
        public static void PrintArray(double[,] array)
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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Введите значение количества строк m: ");
            Console.ResetColor();
            int strings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите значение количества столбцов n: ");
            Console.ResetColor();
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            PrintArray(FillArray(strings, columns));
            Console.WriteLine();            
            Console.ReadKey();
        }
    }
}