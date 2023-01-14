using System;
using System.IO;
using System.Linq;
//Дан файл вещественных чисел, содержащий элементы трехдиагональной матрицы (по строкам).
//Создать новый файл, содержащий элементы ненулевой части данной матрицы (по строкам).

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Matrix.txt";
            string path_new = "New_Matrix.txt";
            String[] S_Size = File.ReadAllLines(path);
            int Last_str = S_Size.Count() - 1;
            using (StreamReader Current = new StreamReader(path))
            {
                String Cur_SMatrix;
                int Str = 0;
                while ((Cur_SMatrix = Current.ReadLine()) != null)
                {
                    string[] Elements = Cur_SMatrix.Split(' ');
                    using (StreamWriter writer = new StreamWriter(path_new, true))
                    {
                        if (Str == 0)
                            writer.WriteLine(Elements[0] + " " + Elements[1]);
                        else if (Str > 0 && Str < Last_str)
                            writer.WriteLine(Elements[Str - 1] + " " + Elements[Str] + " " + Elements[Str + 1]);
                        else
                            writer.WriteLine(Elements[Str - 1] + " " + Elements[Str]);
                    }
                    Str++;
                }
            }
            string Answer = File.ReadAllText(path_new);
            Console.WriteLine(Answer);
            Console.ReadLine();
        }
    }
}
