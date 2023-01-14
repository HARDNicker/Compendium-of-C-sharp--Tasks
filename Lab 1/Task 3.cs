using System;
//6. Даны два действительных положительных числа х и у.
//Арифметические действия над числами пронумерованы (1 – сложение, 2 – вычитание, 3 – умножение, 4 – деление). Составить 
//программу, которая по введенному номеру выполняет то или иное 
//действие над числами. 


namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите первое положительное число = ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе положительное число = ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("1 – сложение, 2 – вычитание, 3 – умножение, 4 – деление, 5 - выход");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        Console.WriteLine("x+y = " + (x + y));
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("x-y = " + (x - y));
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("x*y = " + (x * y));
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("x/y = " + (x / y));
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Производится выход из программы ...");
                        return;
                    default:
                        Console.WriteLine("Такого числа я не знаю ");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
