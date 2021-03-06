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

            if (!(currentThis is null) && !(currentList is null))
            {
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
            else
            {
                return true;
            }

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
            if (Length != 1)
            {
                _tail = _tail.Previous;
                _tail.Next = null;
                Length--;
            }
            else
            {
                EmptyList();
            }
        }

        //5. метод удаление из начала одного элемента
        public void RemoveOneElementFromTheBegin()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (Length != 1)
            {
                _root = _root.Next;
                Length--;
            }
            else
            {
                EmptyList();
            }
        }

        //6. метод удаление по индексу одного элемента
        public void RemoveOneElementByIndex(int index)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (Length != 1)
            {
                DoubleLinkedNode current = GetNodeByIndex(index - 1);
                current.Next.Next.Previous = current.Next;
                current.Next = current.Next.Next;
                Length--;
            }
            else
            {
                EmptyList();
            }
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
            if (Length != n)
            {
                DoubleLinkedNode current = GetNodeByIndex(Length - n - 1);
                //current.Next.Previous = null;
                current.Next = null;
                _tail = current;
                Length -= n;
            }
            else
            {
                EmptyList();
            }
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
            if (Length != n)
            {
                _root = GetNodeByIndex(n);
                Length -= n;
            }
            else
            {
                EmptyList();
            }
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
            if (Length != n)
            {
                DoubleLinkedNode current = GetNodeByIndex(index - 1);
                DoubleLinkedNode newcurrent = GetNodeByIndex(index + n - 1);
                current.Next = newcurrent.Next;
                Length -= n;
            }
            else
            {
                EmptyList();
            }
        }

        //12. метод первый индекс по значению
        public int GetIndexByValue(int value)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            DoubleLinkedNode current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (current.Values == value)
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }

        //14. метод реверс (123 -> 321)
        public void Revers()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }

            DoubleLinkedNode current = _root;
            DoubleLinkedNode tmp1 = null;
            DoubleLinkedNode tmp2 = null;

            while (!(current is null))
            {
                tmp2 = current.Next;
                current.Next = tmp1;
                current.Previous = tmp2;
                tmp1 = current;
                current = tmp2;
            }
            _root = tmp1;
        }

        //15. метод поиск значения максимального элемента
        public int FindMaxValue()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            int max = _root.Values;
            DoubleLinkedNode current = _root;
            for (int i = 1; i <= Length; i++)
            {
                if (max < current.Values)
                {
                    max = current.Values;
                }
                current = current.Next;
            }
            return max;
        }

        //16. метод поиск значения минимального элемента
        public int FindMinValue()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            int min = _root.Values;
            DoubleLinkedNode current = _root;
            for (int i = 1; i <= Length; i++)
            {
                if (min > current.Values)
                {
                    min = current.Values;
                }
                current = current.Next;
            }
            return min;
        }

        //17. метод поиск индекс максимального элемента
        public int FindIndexMaxValue()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            int max = _root.Values, indexMax = 0;
            DoubleLinkedNode current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (max < current.Values)
                {
                    max = current.Values;
                    indexMax = i;
                }
                current = current.Next;
            }
            return indexMax;
        }

        //18. метод поиск индекс минимального элемента
        public int FindIndexMinValue()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            int min = _root.Values, indexMin = 0;
            DoubleLinkedNode current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (min > current.Values)
                {
                    min = current.Values;
                    indexMin = i;
                }
                current = current.Next;
            }
            return indexMin;
        }

        ////19. метод сортировка по возрастанию
        //public void SortAscending()
        //{
        //    if (Length == 0)
        //    {
        //        throw new ArgumentNullException();
        //    }
        //    for (int i = 1; i < Length; i++)
        //    {
        //        for (int j = i; j > 0; j--)
        //        {
        //            DoubleLinkedNode current1 = GetNodeByIndex(j - 1);
        //            DoubleLinkedNode current2 = GetNodeByIndex(j);
        //            if (current1.Values > current2.Values)
        //            {
        //                int tmp = current1.Values;
        //                current1.Values = current2.Values;
        //                current2.Values = tmp;
        //            }
        //        }
        //    }
        //}

        ////20. метод сортировка по убыванию
        //public void SortDescending()
        //{
        //    if (Length == 0)
        //    {
        //        throw new ArgumentNullException();
        //    }
        //    for (int i = 1; i < Length; i++)
        //    {
        //        for (int j = i; j > 0; j--)
        //        {
        //            DoubleLinkedNode current1 = GetNodeByIndex(j - 1);
        //            DoubleLinkedNode current2 = GetNodeByIndex(j);
        //            if (current1.Values < current2.Values)
        //            {
        //                int tmp = current1.Values;
        //                current1.Values = current2.Values;
        //                current2.Values = tmp;
        //            }
        //        }
        //    }
        //}

        //21. метод удаление по значению первого (?вернуть индекс)
        public void RemoveByValueOne(int value)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            RemoveOneElementByIndex(GetIndexByValue(value));
        }

        //22. метод удаление по значению всех (?вернуть кол-во)
        public void RemoveByValueAll(int value)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            DoubleLinkedNode current = _root;
            int i = 0;
            while (i < Length)
            {
                if (current.Values == value)
                {
                    RemoveOneElementByIndex(i);
                    i--;
                }
                current = current.Next;
                i++;
            }
        }

        //24. метод добавление списка (вашего самодельного) в конец
        public void AddValueToTheEnd(DoubleLinkedList dlinkedList)
        {
            Length = Length + dlinkedList.Length;

            _tail.Next = dlinkedList._root;
            dlinkedList._root.Previous = _tail;
            _tail = dlinkedList._tail;
        }

        //25. метод добавление списка в начало
        public void AddValueToTheBegin(DoubleLinkedList dlinkedList)
        {
            Length = Length + dlinkedList.Length;

            dlinkedList._tail.Next = _root;
            _root.Previous = dlinkedList._tail;
            _root = dlinkedList._root;
        }

        //26. метод добавление списка по индексу
        public void AddValueByIndex(DoubleLinkedList linkedList, int index)
        {
            Length = Length + linkedList.Length;
            DoubleLinkedNode current = GetNodeByIndex(index - 1);

            linkedList._tail.Next = current.Next;
            current.Next.Previous = linkedList._tail;

            current.Next = linkedList._root;
            linkedList._root.Previous = current;
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

        // метод пустой список
        private void EmptyList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Length, _root, _tail);
        }
    }
}
