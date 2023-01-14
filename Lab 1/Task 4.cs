using System;
using System.Numerics;
//Составить программу-генератор простых чисел, в основу положить формулу 22n+1+13 при 1 ≤  n ≤36.
//Каждое получаемое число данного вида необходимо проверять на простоту.

namespace Задание_4
{
    class Program
    {
        static bool Prime(BigInteger n)
        {
            for (BigInteger i = 2; i <= (BigInteger)Math.Ceiling(Math.Sqrt((double)n)); i++) //Возвращает наименьшее целое число, которое больше или равно указанному числу.
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            BigInteger stepen = 8;
            for (int n = 1; n <= 36; n++)
            {
                BigInteger formula = (stepen + 1) / 3;
                stepen *= 4;
                Console.WriteLine(Prime(formula) ? " n = {0} Простое число : " + formula : " n = {0} Не простое число : " + formula, n);
            }
            Console.ReadLine();
        }
    }
}
