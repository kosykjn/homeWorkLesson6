using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson6_6
{
    class Program
    {
        static void Print(int[] array, string header)
        {
            Console.WriteLine($"{header}:");

            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        static int[] CreateRandomArray(int n, int minRandomValue, int maxRandomValue)
        {
            int[] array = new int[n];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandomValue, maxRandomValue);
            }

            return array;
        }

        static int GetArrayMax(int[] array)
        {
            int max = int.MinValue;

            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
            }

            return max;
        }

        static int GetArrayMin(int[] array)
        {
            int min = int.MaxValue;

            foreach (int element in array)
            {
                if (element < min)
                {
                    min = element;
                }
            }

            return min;
        }

        static int GetArraySum(int[] array)
        {
            int sum = 0;

            foreach (var element in array)
            {
                sum += element;
            }

            return sum;
        }

        static double GetArrayAvg(int[] array)
        {
            return GetArraySum(array) / (double)array.Length;
        }

        static void PrintArrayOddValues(int[] array, string header)
        {
            Console.WriteLine($"{header}:");

            foreach (var element in array)
            {
                if (element % 2 != 0)
                {
                    Console.Write($"{element} ");
                }             
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов:");
            int amountOfElements = Convert.ToInt32(Console.ReadLine());

            int[] variableArray = CreateRandomArray(amountOfElements, 1, 9);

            Print(variableArray, "Массив случайных чисел");

            Console.WriteLine("Максимальное значение массива {0}", GetArrayMax(variableArray));
            Console.WriteLine("Минимальное значение массива {0}", GetArrayMin(variableArray));
            Console.WriteLine("Сумма всех значений массива {0}", GetArraySum(variableArray));
            Console.WriteLine("Среднее арифметическое значение всех елементов массива {0}", GetArrayAvg(variableArray));

            PrintArrayOddValues(variableArray, "Массив нечетных чисел");

            Console.ReadKey();
        }
    }
}
