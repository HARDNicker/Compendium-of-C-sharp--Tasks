using System;
//Дана строка. Преобразовать ее, заменив точками все двоеточия (:), встречающиеся среди первых n/2 символов,
//и заменив точками все восклицательные знаки, встречающиеся среди символов, стоящих после n/2 символов.

namespace Задание_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку : ");
            string Stroka = Console.ReadLine();
            int n = Stroka.Length;
            Stroka = Stroka.Insert(n / 2, "$");
            String[] Stroka2 = Stroka.Split('$');
            Stroka2[0] = Stroka2[0].Replace(":", ".");
            Stroka2[1] = Stroka2[1].Replace("!", ".");
            Console.WriteLine(String.Join("", Stroka2));
            Console.ReadLine();
        }
    }
}
