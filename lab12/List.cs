using System;
using System.Collections;

namespace data_struct
{
    public class LinkedList<T> : IEnumerable<T>
    {
        //Реалізація "ноди" зв'язаного списку(ліста)
        public class Node
        {
            public T Data;
            public Node Next;
            //Конструктор "ноди" ліста
            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }
        private int _capacity;
        private Node _head;
        private Node _tail;
        //Конструктов класу ліста
        public LinkedList()
        {
            _head = null;
            _tail = null;
            _capacity = 0;
        }
        //Додавання елемента в початок списку
        public void PushFront(T data)
        {
            Node node = new Node(data);
            node.Next = _head;
            _head = node;
            //Випадок пустого ліста
            if (_tail == null)
            {
                _tail = node;
            }
            if(_head == null)
            {
                _head = node;
            }
            _capacity++;
        }
        //Додавання елемента в кінець списку
        public void PushBack(T data)
        {
            Node node = new Node(data);
            if (_head == null)
            {
                _head = node;
                _tail = node;
                _capacity++;
                return;
            }
            _tail.Next = node;
            _tail = node;
            _capacity++;
        }
        //Видалення першого елемента з ліста, здійснюється простою заміную його "голови" на наступний елемент
        public void PopFront()
        {
            //Ліст пустий
            if (_head == null)
            {
                return;
            }
            //Ліст має 1 елемент
            else if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            //Ліст має декілька елементів
            else
            {
                _head = _head.Next;
            }
            _capacity--;
        }
        //Видалення останього елемента з ліста, здійснюється простою заміную його "хвоста" на попередній елемент
        public void PopBack()
        {
            //Ліст пустий
            if (_head == null)
            {
                return;
            }
            //Ліст має 1 елемент
            else if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            //Ліст має декілька елементів
            else
            {
                Node current = _head;
                while (current.Next != _tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                _tail = current;
            }
            _capacity--;
        }

        //Перевірка чи є елементи в лісті
        public bool Empty()
        {
            return _head == null;
        }
        //Поелементний вивід елементів ліста
        public void Print()
        {
            Node cur = _head;
            while (cur != null)
            {
                Console.Write(cur.Data + " ");
                cur = cur.Next;
            }
        }
        //Поточний розмір ліста
        public int Size()
        {
            return _capacity;
        }
        public void Clear()
        {
            _head = null;
            _tail = null;
        }
        public Node First()
        {
            return _head;
        }
        //Індексатор зв'язаного списку, реалізує логіку отримання доступу до елемента, за його встановлення за індексом
        public T this[int index]
        {
            get
            {
                //Умова, за якої елемент знаходиться в лісті
                if (index >= _capacity || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                int cnt = 0;
                Node cur = _head;
                //Доступ до елемента, здійснюється за лінійний час 
                while (cur != null && cnt < index)
                {
                    cur = cur.Next;
                    cnt++;
                }
                return cur.Data;
            }
            set
            {
                if (index >= _capacity || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                int cnt = 0;
                Node cur = _head;
                //Пошук потрібного індекса
                while (cur != null && cnt < index)
                {
                    cur = cur.Next;
                    cnt++;
                }
                //Заміна даних 
                cur.Data = value;
            }
        }
        public IEnumerator<Tuple<T, int>> GetEnumerator()
        {
            Node current = _head;
            int cnt = 0;
            while (current != null)
            {
                yield return new Tuple<T, int>(current.Data, cnt);
                current = current.Next;
                cnt++;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}