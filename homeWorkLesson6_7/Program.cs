using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, 5, 6 };
            Print(inputArray, "InputArray");

            Console.WriteLine("Введите стартовый индекс:");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите кол-во элементов:");
            int count = Convert.ToInt32(Console.ReadLine());

            if (GetSubArrayFromArray(inputArray, index, count, out int[] subArray))
            {
                Print(subArray, "SubArray");
            }
            else
            {
                Console.WriteLine("Не удалось получить SubArray!");
            }

            Console.ReadKey();
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

        static bool GetSubArrayFromArray(int[] array, int startIndex, int count, out int[] subArray)
        {
            if (startIndex + count > array.Length)
            {
                subArray = new int[] { };
                return false;
            }

            subArray = new int[count];

            for (int i = 0; i < count; i++)
            {
                subArray[i] = array[startIndex + i];
            }

            return true;
        }
    }
}
