using System;
using System.Collections.Generic;
//Имеются монеты номиналом 3 и 7 рублей.
//Определите можно ли их этих монет составить сумму в S рублей (S <= 50) и, если можно, предложите любой способ получить эту сумму.

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int Coin3 = 3;
            int Coin7 = 7;
            Console.WriteLine("Введите число: ");
            int N = int.Parse(Console.ReadLine());
            Queue<int> Coins = new Queue<int>();
            if (N <= 50)
            {
                while (s + Coin7 <= N)
                {
                    Coins.Enqueue(Coin7);
                    s += 7;
                }
                while (s != N)
                {
                    Coins.Enqueue(Coin3);
                    s += 3;
                    if (s > N)
                    {
                        if (Coins.Contains(7))
                        {
                            Coins.Dequeue();
                            s -= 7;
                        }
                    }
                    else
                    {
                        while (s < N)
                        {
                            Coins.Enqueue(Coin3);
                            s += 3;
                        }
                    }
                    if (s > N && !Coins.Contains(7))
                    {
                        Console.WriteLine("нет");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                while (Coins.Count > 0)
                {
                    Console.Write(Coins.Dequeue() + " ");
                }
                Console.WriteLine("\nМожно получить число " + s);
                Console.ReadLine();
            }
            else
                Console.WriteLine("Нарушено условие границы числа");
            Console.ReadLine();
        }
    }
}
