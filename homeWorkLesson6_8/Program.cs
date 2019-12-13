using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, 5, 6 };
            Print(inputArray, "InputArray");

            Console.WriteLine("Введите значение которое хотите вставить в начало массива:");
            int value = Convert.ToInt32(Console.ReadLine());

            int[] resultArray = InsertStartValueToArray(inputArray, value);

            Print(resultArray, "ResultArray");

            Console.ReadKey();
        }

        static int[] InsertStartValueToArray(int[] array, int insertValue)
        {
            var resultArray = new int[array.Length + 1];
            resultArray[0] = insertValue;

            for (int i = 0; i < array.Length; i++)
            {
                resultArray[i + 1] = array[i];
            }

            return resultArray;
        }
        static void Print(int[] array, string header)
        {
            Console.WriteLine($"{header}:");

            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}
