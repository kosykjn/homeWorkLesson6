using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string reverseWord = Reverse(Console.ReadLine());
            Console.WriteLine($"Слово в обратном порядке -> {reverseWord}");

            Console.ReadKey();
        }

        static string Reverse(string input)
        {
            var result = new char[input.Length];

            for (int i = input.Length - 1, j = 0; i >= 0; i--, j++)
            {
                result[j] = input[i];
            }

            return new string(result);
        }
    }
}
