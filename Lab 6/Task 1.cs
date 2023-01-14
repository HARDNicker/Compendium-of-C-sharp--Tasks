using System;
using System.IO;
using System.Linq;
//Дан файл целых чисел, содержащий менее 50 элементов.
//Увеличить его размер до 50 элементов, записав в начало файла необходимое количество нулей. 

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "context1.txt";
            string fileText = File.ReadAllText(path);

            char[] delimiterChars = { ' ', ',', '\t', '\r', '\n' };
            string[] Numbers = fileText.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            int n = Numbers.Count();
            int[] Num = new int[50];

            if (n > 50 || n < 0)
            {
                Console.WriteLine("ERROR: Many Item");
                Environment.Exit(0);
            }

            for (int i = 0; i < n; i++)
            {
                Num[i + 50 - n] = int.Parse(Numbers[i]);
            }

            fileText = String.Join(", ", Num);
            File.WriteAllText(path, fileText);
            Console.WriteLine(fileText);
            Console.ReadLine();
        }
    }
}
