using System;

namespace homeWorkLesson6_5
{
    class Program
    {
        static string GetMonthName(int index)
        {
            switch (index)
            {
                case 0: return "январь";
                case 1: return "февраль";
                case 2: return "март";
                case 3: return "апрель";
                case 4: return "май";
                case 5: return "июнь";
                case 6: return "июль";
                case 7: return "август";
                case 8: return "сентябрь";
                case 9: return "октябрь";
                case 10: return "ноябрь";
                case 11: return "декабрь";
                default: return "-";
            }
        }

        static void Main(string[] args)
        {
            int[] monthlyProfit = new int[12];

            for (int i = 0; i < monthlyProfit.Length; i++)
            {
                Console.WriteLine($"Введите прибыль за {GetMonthName(i)}:");
                monthlyProfit[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите начальный месяц для проверки прибыли:");
            int startingMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечный месяц:");
            int endMonth = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue;
            int min = int.MaxValue;           

            for (int i = startingMonth; i < endMonth; i++)
            {
                if (monthlyProfit[i] > max)
                {
                    max = monthlyProfit[i];                  
                }
                if (monthlyProfit[i] < min)
                {
                    min = monthlyProfit[i];
                }
            }

            Console.WriteLine("Максимальная прибыль в месяц за период: {0}", max);
            Console.WriteLine("Минимальная прибыль в месяц за период: {0}", min);

            Console.ReadKey();
        }
    }
}
