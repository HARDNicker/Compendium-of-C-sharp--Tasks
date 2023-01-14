using System;
//Вычислите заданные формулы, все переменные вводятся с клавиатуры, результат печатается на экран.
//Для вычисления математических функций используются статические методы класса Math:

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число z = ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число d = ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число f = ");
            int f = int.Parse(Console.ReadLine());
            double formula = ((Math.Pow((Math.Cos(x)), 2)) / Math.Sin(x)) - (x * y * z) - ((a * Math.Pow(x, 2) + b * x + c) / (d * Math.Pow(x, 3) - f));
            Console.WriteLine("Ответ по используемой формуле = " + formula);
            Console.ReadLine();
        }
    }
}
