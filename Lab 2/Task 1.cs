using System;
//Найти наименьший номер n члена последовательности, для которого выполняется условие an- an-1 < ɛ. Вывести на экран этот номер и все элементы ai,  где i = 1, 2,..., n.

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите e>0");
            double e = double.Parse(Console.ReadLine());
            if (e > 0)
            {
                double a1 = 2;
                double a2 = (2 + a1 * a1) / (2 * a1);
                int n = 1;
                Console.WriteLine("n= " + n + " a = " + a1);
                while (Math.Abs(a2 - a1) >= e)
                {
                    n += 1;
                    Console.WriteLine("n= " + n + " a = " + a2);
                    a1 = a2;
                    a2 = (2 + a1 * a1) / (2 * a1);
                }
                Console.WriteLine("n= " + n + " |a2-a1|= " + (Math.Abs(a2 - a1)));
            }
            else
                Console.WriteLine("Отрицательное число ");
            Console.ReadLine();
        }
    }
}
