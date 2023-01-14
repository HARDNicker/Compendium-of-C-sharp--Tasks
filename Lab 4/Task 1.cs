using System;
using System.Collections.Generic;
//Имеется два стека действительных чисел, напишите программу, объединяющую их в один стек.

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] znach1 = new double[] { 1, 2, 3, 4, 5 };
            double[] znach2 = new double[] { 10, 9, 8, 7, 6 };
            Stack<double> deistv1 = new Stack<double>(znach1);
            Stack<double> deistv2 = new Stack<double>(znach2);
            while (deistv2.Count > 0)
            {
                deistv1.Push(deistv2.Pop());
            }
            while (deistv1.Count > 0)
            {
                Console.WriteLine(deistv1.Pop());
            }
            Console.ReadLine();
        }
    }
}
