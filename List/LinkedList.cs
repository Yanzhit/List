using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class LinkedList
    {
        public int Length { get; private set; }     // свойство
        private Node _root;
        private Node _tail;

        public int this[int index]
        {
            get
            {
                if (index > Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Node current = _root;
                for (int i=1; i<=index; i++)
                {
                    current = current.Next;
                }
                //GetNodeByIndex(index);
                return current.Values;
            }
            set
            {
                Node current = _root;
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                //GetNodeByIndex(index);
                current.Values = value;
            }
        }

        public override string ToString()
        {
            if (Length!=0)
            {
                Node current = _root;
                string s = current.Values + " ";
                while (!(current.Next is null))
                {
                    current = current.Next;
                    s += current.Values + " ";
                }
                return s;
            }
            else
            {
                return String.Empty;
            }
        }

        public override bool Equals (object obj)
        {
            LinkedList list = (LinkedList)obj;

            if (this.Length!=list.Length)
            {
                return false;
            }

            Node currentThis = this._root;
            Node currentList = list._root;

            while (!(currentThis.Next is null))
            {
                if (currentThis.Values != currentList.Values)
                {
                    return false;
                }
                currentList = currentList.Next;
                currentThis = currentThis.Next;
            }
            if (currentThis.Values != currentList.Values)
            {
                return false;
            }
            return true;
        }

        // конструктор пустой 
        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }
        
        // конструктор на основе одного элемента
        public LinkedList(int values)
        {
            Length = 1;
            _root = new Node(values);
            _tail = _root;
        }

        // конструктор на основе массива
        public LinkedList(int[] values)
        {
            if (values is null)
            {
                throw new NullReferenceException();
            }
            Length = values.Length;

            if (values.Length!=0)
            {
                _root = new Node(values[0]);
                _tail = _root;
                for (int i=1; i<values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }

        //1. метод добавление значения в конец
        public void AddValueToTheEnd(int value)
        {
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }

        //2. метод добавление значения в начало
        public void AddValueToTheBegin(int value)
        {
            Length++;
            Node tmp = new Node(value);
            tmp.Next = _root;
            _root = tmp;
        }

        //3. метод добавление значения по индексу
        public void AddValueByIndex(int value, int index)
        {
            Length++;
            Node current = _root;
            for (int i = 1; i < index; i++)
            {
                current = current.Next;
            }

            Node tmp = new Node(value);
            tmp.Next = current.Next;
            current.Next = tmp;
        }

        //4. метод удаление из конца одного элемента
        public void RemoveOneElementFromTheEnd()
        {
            Node current = _root;
            for (int i = 1; i < Length-1; i++)
            {
                current = current.Next;
            }            
            current.Next = null;
            _tail = current;
            Length--;
        }

        //5. метод удаление из начала одного элемента
        public void RemoveOneElementFromTheBegin()
        {
            _root = _root.Next;
            Length--;
        }

        //6. метод удаление по индексу одного элемента
        public void RemoveOneElementByIndex(int index)
        {
            Node current = GetNodeByIndex(index-1);
            current.Next = current.Next.Next;
            Length--;
        }

        //7. удаление из конца N элементов
        public void RemoveNElementsFromTheEnd(int n)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (n > Length)
            {
                throw new ArgumentException();
            }
            Node current = GetNodeByIndex(Length - n - 1);
            current.Next = null;
            _tail = current;
            Length--;
        }

        //8.удаление из начала N элементов
        public void RemoveNElementsFromTheBegin(int n)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (n > Length)
            {
                throw new ArgumentException();
            }
            _root = GetNodeByIndex(n);
            Length--;
        }

        //9.удаление по индексу N элементов
        public void RemoveByIndexNElements(int index, int n)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (n > Length)
            {
                throw new ArgumentException();
            }
            Node current = GetNodeByIndex(index - 1); 
            Node newcurrent = GetNodeByIndex(index + n - 1);
            current.Next= newcurrent.Next;
            Length--;
        }

        private Node GetNodeByIndex(int index)
        {
            Node current = _root;
            for (int i = 1; i <= index; i++)
            {
                current = current.Next;
            }
            return current;
        }
    }
}
