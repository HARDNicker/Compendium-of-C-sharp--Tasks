using System;
//Реализовать предыдущий класс и продемонстрировать его применение,
//используя для событий стандартные обобщенные делегаты Func, Action или EventHandler
//(на выбор, но все события должны быть описаны через стандартные обобщенные делегаты).
//Работа с событиями, делегатами и исключениями.
//Написать программу, в которой реализованы следующие классы по вариантам.
//В коде должно демонстрироваться использование классов.
//Также должно быть создано не менее двух собственных исключений, необходимо реализовать их генерацию и обработку.

namespace Задание_2
{
    public delegate void Action<in T>(T obj);
    public class Computer
    {
        public string Message { get; }
        public string Name_Printer { get; }
        public Computer(string message, string name_Printer)
        {
            Message = message;
            Name_Printer = name_Printer;
        }
    }
    public delegate void FunctionPrinter(string message);
    public class Printer
    {
        private readonly string Name_Printer;
        public readonly string Date_Of;
        private readonly int Size_Lot;
        public int Size_Current;

        public delegate void PrinterHandler(Printer sender, Computer Name);
        public event Action<string> Notify;
        FunctionPrinter DoIt;
        public void RegisterHandler(FunctionPrinter del)
        {
            DoIt += del;
        }
        public void UnregisterHandler(FunctionPrinter del)
        {
            DoIt -= del;
        }
        public Printer(string name_Printer, string date_Of, int size_Lot, int size_Current)
        {
            Name_Printer = name_Printer;
            Date_Of = date_Of;
            Size_Lot = size_Lot;
            Size_Current = size_Current;
            if (size_Current > size_Lot) throw new ArgumentException();
        }

        public void AddPaper(int Paper)
        {
            if (Size_Current < Size_Lot)
            {
                Size_Current += Paper;
                Notify?.Invoke($"Добавлено {Paper} листов в принтер {Name_Printer}");
            }
            else
            {
                DoIt?.Invoke($"Переполнение лотка принтера {Name_Printer} емкостью {Size_Lot}, текущее количество листов в принтере = {Size_Current}");
                throw new OverflowException();
            }
        }

        public void PrinterPrint(int CountPaper)
        {
            DoIt?.Invoke($"Производится печать документа емкостью {CountPaper} страниц с принтера {Name_Printer} ....");
            int Done = 0;
            while (Size_Current > 0)
            {
                Size_Current -= 1;
                Done++;
                DoIt?.Invoke($"Распечатана {Done} страница....");
                if (Done == CountPaper)
                {
                    Notify?.Invoke($"Документ распечатан с принтера {Name_Printer}");
                    break;
                }
                else if (Done != CountPaper && Size_Current == 0)
                {
                    DoIt?.Invoke($"Недостаточно листов для печати {CountPaper - Done} листов в принтере {Name_Printer}"); ;
                }
                if (Size_Current == 0 && Done != CountPaper)
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
    internal class Program
    {
        static void PrintSimpleMessage(string message) => Console.WriteLine(message);
        static void Main(string[] args)
        {
            try
            {
                Printer Dell = new Printer("Dell", "06/12/2022", 200, 100);
                Dell.RegisterHandler(PrintSimpleMessage);
                Dell.AddPaper(20);
                Dell.PrinterPrint(100);
                Dell.PrinterPrint(150);
                Console.ReadLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Переполнение лотка принтера");
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Ошибка: Недостаточно листов для печати");
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Ошибка: Листов внутри не может быть больше,чем вместимость лотка принтера");
                Console.ReadLine();
            }
        }
    }
}
