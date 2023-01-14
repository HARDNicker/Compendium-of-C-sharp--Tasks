using System;
//Написать программу для решения системы линейных уравнений 

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты a, b, c первого уравнения");
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициенты a, b, c со второго уравнения");
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double c2 = double.Parse(Console.ReadLine());
            //решим методом Крамера
            double d = a1 * b2 - a2 * b1;
            double d1 = c1 * b2 - b1 * c2;
            double d2 = c2 * a1 - a2 * c1;
            if (d == 0)
            {
                if (d2 == 0)
                {
                    Console.WriteLine(" Бесконечное количество решений");
                    Console.ReadLine();
                }
                else { Console.WriteLine(" Система решений не имеет"); Console.ReadLine(); }
            }
            else
            {
                double x = d1 / d;
                double y = d2 / d;
                Console.WriteLine("x=" + x + " y=" + y);
                Console.ReadLine();
            }
        }
    }
}
