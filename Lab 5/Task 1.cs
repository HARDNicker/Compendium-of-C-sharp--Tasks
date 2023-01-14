using System;
using System.Collections.Generic;
using System.Linq;
//Выведите слово, которое в этом тексте встречается чаще всего.
//Если таких слов несколько, выведите то, которое меньше в лексикографическом порядке.

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст : ");
            string text = Console.ReadLine();
            text = text.ToLower();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, int> Dic = new SortedDictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (Dic.ContainsKey(words[i]))
                    Dic[words[i]]++;
                else
                    Dic.Add(words[i], 1);
            }
            int max = Dic.Values.Max();
            for (int i = 0; i < Dic.Count; i++)
                if (max == Dic[words[i]])
                    Console.WriteLine("Words = {0} Count = {1}", Dic.Keys.First(), Dic.Values.First());
            Console.ReadLine();
        }
    }
}
