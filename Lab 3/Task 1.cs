using System;
//В данной действительной квадратной матрице порядка п найти наибольший по модулю элемент.
//Получить квадратную матрицу порядка (п – 1) путем отбрасывания в исходной матрице строки и столбца, на пересечении которых расположен элемент с найденным значением.

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задать квадратную матрицу, найти наибольший по модулю элемент и путем отбрасывания строки и столбца получить квадратную матрицу");
            Console.Write("Введите размерность матрицы N=");
            int N = int.Parse(Console.ReadLine());
            int[,] Array = new int[N, N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    Array[i, j] = rand.Next(100);
            Console.WriteLine("Наша матрица : ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write("{0,5}", Array[i, j]);
                Console.WriteLine();
            }
            int max = 0;
            int m = 0;
            int n = 0;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    if (Math.Abs(Array[i, j]) > max)
                    {
                        max = Math.Abs(Array[i, j]);
                        m = i;
                        n = j;
                    }
                }
            Console.WriteLine("Наибольший по модулю элемент {0} и имеет координаты ({1};{2})", Array[m, n], m + 1, n + 1);
            int[,] NewArray = new int[N - 1, N - 1];
            int NewI = 0;
            int NewJ = 0;
            for (int i = 0; i < N; i++)
            {
                if (i != m)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (j != n)
                        {
                            NewArray[NewI, NewJ] = Array[i, j];
                            NewJ++;
                        }
                    }
                    NewI++;
                    NewJ = 0;
                }
            }
            Console.WriteLine("Новая матрица примет вид : ");
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - 1; j++)
                    Console.Write("{0,5}", NewArray[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
