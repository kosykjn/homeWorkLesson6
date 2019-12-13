using System;

namespace homeWorkLesson6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива N:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = CreateRandomArray(n, 1, 9);

            Print(array, "Input array");

            PrintArrayRowSums(array);

            PrintArrayColMultiply(array);

            Console.WriteLine($"Максимальный элемент по главной диагонали: {GetMainDiagonalMaxElement(array)}");

            Console.ReadKey();
        }

        static int[,] CreateRandomArray(int n, int minRandomValue, int maxRandomValue)
        {
            int[,] array = new int[n, n];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minRandomValue, maxRandomValue);
                }
            }

            return array;
        }
        static int GetMainDiagonalMaxElement(int[,] array)
        {
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (max < array[i, j])
                        {
                            max = array[i, j];
                        }
                    }
                }
            }

            return max;
        }

        static int GetRowSum(int[,] array, int rowIndex)
        {
            int sum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[rowIndex, j];
            }

            return sum;
        }

        static void PrintArrayRowSums(int[,] array)
        {
            Console.WriteLine("Суммы элементов в каждом ряду:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Сумма ряда {i} -> {GetRowSum(array, i)}");
            }
        }

        static int GetColMultiply(int[,] array, int colIndex)
        {
            int multiply = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiply *= array[i, colIndex];
            }

            return multiply;
        }

        static void PrintArrayColMultiply(int[,] array)
        {
            Console.WriteLine("Произведение элементов в каждом столбце:");

            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.WriteLine($"Произведение столбца {i} -> {GetColMultiply(array, i)}");
            }
        }

        static void Print(int[,] array, string header)
        {
            Console.WriteLine($"{header}:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }

                Console.WriteLine();
            }
        }
       
    }
}
