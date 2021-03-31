using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class DoubleLinkedList
    {
        public int Length { get; private set; }     // свойство
        private DoubleLinkedNode _root;
        private DoubleLinkedNode _tail;

        // конструктор пустой 
        public DoubleLinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        // конструктор на основе одного элемента
        public DoubleLinkedList(int values)
        {
            Length = 1;
            _root = new DoubleLinkedNode(values);
            _tail = _root;
        }

        // конструктор на основе массива
        public DoubleLinkedList(int[] values)
        {
            if (values is null)
            {
                throw new NullReferenceException();
            }
            Length = values.Length;

            if (values.Length != 0)
            {
                _root = new DoubleLinkedNode(values[0]);
                _tail = _root;
                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new DoubleLinkedNode(values[i]);
                    _tail.Next.Previous = _tail;
                    _tail = _tail.Next;
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }


        public override string ToString()
        {
            if (Length != 0)
            {
                DoubleLinkedNode current = _root;
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

        public override bool Equals(object obj)
        {
            DoubleLinkedList list = (DoubleLinkedList)obj;

            if (this.Length != list.Length)
            {
                return false;
            }

            DoubleLinkedNode currentThis = this._root;
            DoubleLinkedNode currentList = list._root;

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


        //11. метод доступ по индексу 
        //13. метод изменение по индексу
        public int this[int index]
        {
            get
            {
                if (Length == 0)
                {
                    throw new ArgumentNullException();
                }
                if (index > Length)
                {
                    throw new IndexOutOfRangeException();
                }
                DoubleLinkedNode current = GetNodeByIndex(index);
                return current.Values;
            }
            set
            {
                if (index > Length)
                {
                    throw new IndexOutOfRangeException();
                }
                DoubleLinkedNode current = GetNodeByIndex(index);
                current.Values = value;
            }
        }


        //1. метод добавление значения в конец
        public void AddValueToTheEnd(int value)
        {
            if (Length != 0)
            {
                Length++;
                _tail.Next = new DoubleLinkedNode(value);
                _tail = _tail.Next;
            }
            else
            {
                AddValueToEmptyList(value);
            }
        }

        //2. метод добавление значения в начало
        public void AddValueToTheBegin(int value)
        {
            if (Length != 0)
            {
                Length++;
                _root.Previous = new DoubleLinkedNode(value);
                _root = _root.Previous;
            }
            else
            {
                AddValueToEmptyList(value);
            }
        }

        //3. метод добавление значения по индексу
        public void AddValueByIndex(int value, int index)
        {
            if (index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (Length != 0 && Length != 1)
            {
                Length++;
                DoubleLinkedNode current = GetNodeByIndex(index - 1);

                DoubleLinkedNode tmp = new DoubleLinkedNode(value);
                tmp.Next = current.Next;
                current.Next = tmp;
            }
            else
            {
                if (Length == 0)
                {
                    AddValueToEmptyList(value);
                }
                else
                {
                    AddValueToTheBegin(value);
                }
            }
        }

        //4. метод удаление из конца одного элемента
        public void RemoveOneElementFromTheEnd()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            _tail = _tail.Previous;
            _tail.Next = null;
            Length--;
        }

        //5. метод удаление из начала одного элемента
        public void RemoveOneElementFromTheBegin()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            _root = _root.Next;
            Length--;
        }



        //метод возвращающий Node по индексу
        public DoubleLinkedNode GetNodeByIndex(int index)
        {
            if (index <= Length / 2)
            {
                DoubleLinkedNode current = _root;
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                return current;
            }
            else
            {
                DoubleLinkedNode current = _tail;
                for (int i = Length - 1; i >= index; i--)
                {
                    current = current.Previous;
                }
                return current;
            }
        }

        // метод добавления значения в пустой список
        private DoubleLinkedNode AddValueToEmptyList(int values)
        {
            Length = 1;
            _root = new DoubleLinkedNode(values);
            _tail = _root;
            return _root;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Length, _root, _tail);
        }
    }
}
