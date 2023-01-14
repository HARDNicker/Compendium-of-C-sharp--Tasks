using System;
//Дано натуральное число п. Переставить его цифры так, чтобы образовалось максимальное число, записанное теми же цифрами.
namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int m = 0;
                for (int i = 9; i >= 0; i--)
                {
                    int p = n;
                    while (p > 0)
                    {
                        int k = p % 10;
                        if (k == i)
                            m = m * 10 + k;
                        p /= 10;
                    }
                }
                Console.WriteLine("M = " + m);
                Console.ReadLine();
            }
        }
    }
}
