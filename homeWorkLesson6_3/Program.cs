using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayA = new string [4];
            string[] arrayB = new string [4];

            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = Console.ReadLine();
            }

            Console.WriteLine(new string('*', 20));

            for (int i = arrayA.Length-1; i >= 0; i--)
            {
                arrayB[i] = arrayA[i];
                Console.WriteLine(arrayB[i]);
            }
            
            Console.ReadKey();
        }
    }
}
