using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//Реализовать шаблон класса очереди (+Обработка исключений)

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
    public class Queue<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }

        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
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
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Queue<string> queueString = new Queue<string>();
                Console.WriteLine(queueString.First());
                Console.WriteLine("Наша String очередь: ");
                queueString.Enqueue("Andrey");
                queueString.Enqueue("Vlad");
                queueString.Enqueue("Artyom");
                queueString.Enqueue("Dima");

                foreach (string item in queueString)
                    Console.WriteLine(item);

                string FirstStringItem = queueString.Dequeue();
                Console.WriteLine($"\nИзвлеченный элемент: {FirstStringItem}");

                Console.WriteLine("\nНаша очередь без элемента: ");
                foreach (string item in queueString)
                    Console.WriteLine(item);

                Queue<int> queueInt = new Queue<int>();
                Console.WriteLine("\nНаша Int очередь: ");
                queueInt.Enqueue(151);
                queueInt.Enqueue(234);
                queueInt.Enqueue(555);
                queueInt.Enqueue(777);

                foreach (int item in queueInt)
                    Console.WriteLine(item);
                int FirstIntItem = queueInt.Dequeue();
                Console.WriteLine($"\nИзвлеченный элемент: {FirstIntItem}");
                Console.WriteLine();

                Console.WriteLine("Наша очередь без элемента: ");
                foreach (int item in queueInt)
                    Console.WriteLine(item);
                Console.ReadLine();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}
