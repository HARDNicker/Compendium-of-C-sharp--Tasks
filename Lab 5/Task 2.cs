using System;
using System.Collections.Generic;
//Дан текст: в первой строке записано число строк, далее идут сами строки. О
//пределите, сколько различных слов содержится в этом тексте.

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк : ");
            String N_String = Console.ReadLine();
            Console.WriteLine("Введите текст : ");
            string text = (Console.ReadLine());
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> myHash = new HashSet<string>();
            for (int i = 0; i < words.Length; i++)
            {
                myHash.Add(words[i]);
            }
            Console.WriteLine("Количество различных слов в тексте {0}", myHash.Count);

            Console.ReadLine();
        }
    }
}
