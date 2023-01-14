using System;
//Пусть даны две неубывающие последовательности действительных чисел a1 ≤  a2 … ≤ an и b1 ≤  b2 … ≤ bm .
//Требуется указать те места, на которые нужно вставлять элементы последовательности  b1,  b2,…  bm в первую последовательность так, чтобы новая последовательность оставалась возрастающей.

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество элементов первого массива = ");
            int n1 = int.Parse(Console.ReadLine());
            double[] a = new double[n1];
            Console.WriteLine("\nВведите неубывающую последовательность действительных чисел первого массива ");
            for (int i = 0; i < n1; i++)
                a[i] = double.Parse(Console.ReadLine());
            Console.WriteLine("Количество элементов второго массива = ");
            int n2 = int.Parse(Console.ReadLine());
            double[] b = new double[n2];
            Console.WriteLine("\nВведите неубывающую последовательность действительных чисел второго массива ");
            for (int i = 0; i < n2; i++)
                b[i] = double.Parse(Console.ReadLine());
            double[] result = new double[n1 + n2];
            int Num = 0;
            int count = 0;
            for (int i = 0; i < n1; i++, Num++)
            {
                if (count < n2 && b[count] <= a[i])
                {
                    result[Num] = b[count];
                    Console.Write(" {" + result[Num] + "} ");
                    count++;
                    i--;
                }
                else
                {
                    result[Num] = a[i];
                    Console.Write("  " + result[Num] + "  ");
                }
            }
            if (count < n2)
                for (int i = count; i < n2; i++, Num++)
                {
                    result[Num] = b[i];
                    Console.Write(" {" + result[Num] + "} ");
                }
            Console.ReadLine();
        }
    }
}
