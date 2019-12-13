using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] = random.Next(1, 100));
            }

            Console.ReadKey();
        }
    }
}
