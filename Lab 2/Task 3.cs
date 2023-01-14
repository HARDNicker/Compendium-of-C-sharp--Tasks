using System;
//В одномерном массиве с четным количеством элементов (2N) находятся координаты N точек плоскости.
//Они располагаются в следующем порядке: x1, y1, x2, y2, x3, y3 и т.д.
//Определить минимальный радиус окружности с центром в начале координат, которая содержит все точки.

namespace Задание_3
{
    class Program
    {
        static double Radius(double x, double y)
        {
            double Radiuss = Math.Sqrt(x * x + y * y);
            return Radiuss;
        }

        static void Main(string[] args)
        {
            const int nmax = 15;
            double[] a = new double[2 * nmax];
            Random rand = new Random();
            Console.WriteLine("Введите четное количество точек до " + nmax + " n = ");
            int n = int.Parse(Console.ReadLine());
            if (n <= nmax)
            {
                for (int i = 1; i <= (2 * n); i++)
                {
                    a[i] = rand.NextDouble();
                }
                Console.WriteLine("Координаты точек :  ");
                Console.WriteLine(" ");
                Console.WriteLine("x: ");
                for (int i = 1; i <= n; i++)
                    Console.WriteLine("x" + i + "-> " + a[2 * i - 1]);
                Console.WriteLine(" ");
                Console.WriteLine("y: ");
                for (int i = 1; i <= n; i++)
                    Console.WriteLine("y" + i + "-> " + a[2 * i]);
                Console.WriteLine(" ");
                double r = Radius(a[1], a[2]);
                for (int i = 3; i <= (2 * n); i += 2)
                    if (Radius(a[i], a[i + 1]) > r)
                        r = Radius(a[i], a[i + 1]);
                Console.WriteLine("Минимальный радиус = " + r);
                Console.ReadLine();
            }

        }
    }
}
