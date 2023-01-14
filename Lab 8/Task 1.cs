using System;

/*Создать класс 2-мерной фигуры с чисто виртуальными методами печати, вычисления площади и периметра.
От него наследовать классы параллелограмма и полукруга, в них реализовать данные методы.
В производных классах задать поля, определяющие соответствующие фигуры, а также методы доступа к ним на чтение и запись.
*/


namespace Задание_1
{
    abstract class Figure
    {
        public abstract double getArea();
        public abstract double getPerimeter();
        public abstract void Print();

    }
    class Parallelogram : Figure
    {
        public double BaseFoundation { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public override double getPerimeter() => 2 * (Height + Width);
        public override double getArea() => BaseFoundation * Width;
        public override void Print() => Console.WriteLine($"Периметр параллелограмма = {getPerimeter()}, площадь параллелограмма = {getArea()}");
    }
    class Semi_Circle : Figure
    {
        public double Radius { get; set; }
        public override double getPerimeter() => 3.14 * Radius + 2 * Radius;
        public override double getArea() => (3.14 * (Radius * Radius)) / 2;
        public override void Print() => Console.WriteLine($"Периметр полукруга = {getPerimeter()}, площадь полукруга = {getArea()}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parallelogram rectangle = new Parallelogram { BaseFoundation = 10, Width = 20, Height = 10 };
            Semi_Circle circle = new Semi_Circle { Radius = 100 };
            Figure[] mas = { rectangle, circle };

            foreach (var ma in mas)
            {
                ma.Print();
                Console.WriteLine(ma.getArea());
            }

            Console.ReadLine();
        }
    }
}
