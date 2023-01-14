using System;
using System.IO;
//Дан строковый файл, содержащий даты в формате «день/месяц/год», причем под день и месяц отводится по две позиции,
//а под год — четыре (например, «16/04/2001»).
//Найти строку, содержащую самую позднюю осеннюю дату.
//Если даты с требуемым временем года в файле отсутствуют, то вывести пустую строку.

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "dates.txt";
            int maxD = 1;
            int maxM = 7;
            String Last_D = " ";
            using (StreamReader Current = new StreamReader(path))
            {
                String date;
                while ((date = Current.ReadLine()) != null)
                {
                    string[] D_M_Y = date.Split('/', ' ');
                    int curD = int.Parse(D_M_Y[0]);
                    int curM = int.Parse(D_M_Y[1]);
                    if ((curM <= 11 && curM >= 7) && (curM >= maxM && curD >= maxD))
                    {
                        Last_D = date;
                        maxD = curD;
                        maxM = curM;
                    }
                }
            }
            Console.WriteLine(Last_D == " " ? " " : "Самая поздняя дата = " + Last_D);
            Console.ReadLine();
        }
    }
}
