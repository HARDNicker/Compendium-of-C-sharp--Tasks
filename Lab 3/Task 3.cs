using System;
//Форматирование текста. Дан текст, состоящий из предложений, разделяемых точками.
//Напишите программу, производящую следующее форматирование: после каждой точки в конце предложения должен стоять хотя бы один пробел;
//первое слово в предложении должно начинаться с прописной буквы.
//Замечание.Текст может быть как на русском, так и на английском языке.

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст : ");
            string[] text = Console.ReadLine().Split('.');

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != string.Empty)
                {
                    string temp = text[i];
                    while (temp[0] == ' ')
                        temp = temp.Substring(1);
                    temp = temp[0].ToString().ToUpper() + temp.Substring(1) + ". ";
                    text[i] = temp;
                }
            }
            Console.Write("Обработанный текст:");
            Console.WriteLine(String.Join("", text));
            Console.ReadKey();
        }
    }
}
