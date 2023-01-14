using System;
using System.Collections;
using System.Collections.Generic;
/* Описать класс линейного списка. Предусмотреть методы для:
1. Проверки его пустоты
2. Перечисления всех элементов (доступ ко всем элементам по очереди)
3. Удаления произвольного элемента
4. Получения длины списка
5. Объединения двух списков
Напишите программу, которая демонстрирует работу с данным классом. Она должна использовать все реализованные методы класса.
*/

namespace Задание_1
{
    public class Node<T>
    {

        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
        }
    }
    public class LineList<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public LineList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public LineList(T data)
        {
            Node<T> node = new Node<T>(data);
            head = node;
            tail = node;
            count = 1;
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Concat(LineList<T> items)
        {
            if (head == null)
            {
                head = items.head;
            }
            else
            {
                tail.Next = items.head;
            }
            tail = items.tail;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            LineList<string> lineList = new LineList<string>();

            if (lineList.IsEmpty)
                Console.WriteLine("Первый список пуст на данный момент ");
            else
                Console.WriteLine("В списке что то есть ");

            Console.WriteLine("Добавление элементов в первый список : Vlad, Pasha, Dima, Nikita ");
            lineList.Add("Vlad");
            lineList.Add("Pasha");
            lineList.Add("Dima");
            lineList.Add("Nikita");
            Console.WriteLine("Длина первого списка на данный момент = " + lineList.Count);

            Console.WriteLine("Вывод первого списка: ");
            foreach (var item in lineList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Удаляем элемент Nikita ");
            lineList.Remove("Nikita");
            Console.WriteLine("Вывод первого списка без Nikita: ");
            foreach (var item in lineList)
            {
                Console.WriteLine(item);
            }

            LineList<string> lineList2 = new LineList<string>();
            Console.WriteLine("Добавление элемента во второй список : Stepa ");
            lineList2.Add("Stepa");

            Console.WriteLine("Вывод объедененных списков: ");
            lineList.Concat(lineList2);
            foreach (var item in lineList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
