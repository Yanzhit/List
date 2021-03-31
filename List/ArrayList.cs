using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ArrayList
    {
        public int Length { get; private set; }  // свойство
        private int[] _array;                    // поле

        // конструктор пустой 
        public ArrayList()
        {
            Length = 0;                    //длина пользов
            _array = new int[1];           // реальная длина массива
        }

        // конструктор на основе одного элемента
        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[2];
            _array[0] = value;
        }

        // конструктор на основе массива
        public ArrayList(int[] value)
        {
            Length = value.Length;
            _array = value;
            UpSize();
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Length; i++)
            {
                s += _array[i] + " ";
            }
            return s;
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;
            if (Length != arrayList.Length)
            {
                return false;
            }
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] != arrayList._array[i])
                {
                    return false;
                }
            }
            return true;
        }

        //1. метод добавление значения в конец
        public void AddValueToTheEnd(int value)
        {
            AddValueByIndex(value, Length);
        }

        //2. метод добавление значения в начало
        public void AddValueToTheBegin(int value)
        {
            AddValueByIndex(value, 0);
        }

        //3. метод добавление значения по индексу
        public void AddValueByIndex(int value, int index)
        {
            if (index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (Length >= _array.Length)
            {
                UpSize();
            }
            for (int i = Length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[index] = value;
            Length++;
        }

        //4. метод удаление из конца одного элемента
        public void RemoveOneElementFromTheEnd()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            RemoveOneElementByIndex(Length);
        }

        //5. метод удаление из начала одного элемента
        public void RemoveOneElementFromTheBegin()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            RemoveOneElementByIndex(0);
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
            for (int i = index; i < Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            if (Length < (_array.Length / 2))
            {
                DownSize();
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
            RemoveByIndexNElements(Length - 1, n);
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
            RemoveByIndexNElements(0, n);
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
            for (int i = index; (i + n) < Length; i++)
            {
                _array[i] = _array[i + n];
            }
            Length -= n;
            if (Length < (_array.Length / 2))
            {
                DownSize();
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
                return _array[index];
            }
            set
            {
                if (index > Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }
        /*
        //11. метод доступ по индексу 
        public int GetValueByIndex(int index)
        {
            if (index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            return _array[index];
        }
        //13. метод изменение по индексу
        public void ChangeByIndex(int index, int value)
        {
            _array[index] = value;
        }
        */
        //12. метод первый индекс по значению
        public int GetIndexByValue(int value)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
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
            for (int i = 0; i < Length / 2; i++)
            {
                int tmp;
                tmp = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmp;
            }
        }

        //15. метод поиск значения максимального элемента
        public int FindMaxValue()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                }
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
            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                }
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
            //return GetIndexByValue(FindMaxValue());
            int max = _array[0], indexMax=0;
            for (int i = 1; i < Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                    indexMax = i;
                }
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
            //return GetIndexByValue(FindMinValue());
            int min = _array[0], indexMin=0;
            for (int i = 1; i < Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                    indexMin = i;
                }
            }
            return indexMin;
        }

        //19. метод сортировка по возрастанию
        public int[] SortAscending(int leftIndex, int rightIndex)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            int i = leftIndex, j = rightIndex, mid = _array[(i + j) / 2], tmp;
            do
            {
                while (_array[i] < mid)
                {
                    i++;
                }
                while (mid < _array[j])
                {
                    j--;
                }
                if (i <= j)
                {
                    tmp = _array[i];
                    _array[i] = _array[j];
                    _array[j] = tmp;
                    i++;
                    j--;
                }
            }
            while (i <= j);
            if (leftIndex < j)
            {
                SortAscending(leftIndex, j);
            }
            if (i < rightIndex)
            {
                SortAscending(i, rightIndex);
            }
            return _array;
        }
        /*
        public int[] SortAscending()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            int tmp;
            for (int i = 0; i < Length; i++)
            {
                for (int j = Length - 1; j > i; j--)
                {
                    if (_array[j - 1] > _array[j])
                    {
                        tmp = _array[j - 1];
                        _array[j - 1] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
            return _array;
        }
        */
        //20. метод сортировка по убыванию
        public int[] SortDescending(int leftIndex, int rightIndex)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            int i = leftIndex, j = rightIndex, mid = _array[(i + j) / 2], tmp;
            do
            {
                while (_array[i] > mid)
                {
                    i++;
                }
                while (mid > _array[j])
                {
                    j--;
                }
                if (i <= j)
                {
                    tmp = _array[i];
                    _array[i] = _array[j];
                    _array[j] = tmp;
                    i++;
                    j--;
                }
            }
            while (i <= j);
            if (leftIndex < j)
            {
                SortDescending(leftIndex, j);
            }
            if (i < rightIndex)
            {
                SortDescending(i, rightIndex);
            }
            return _array;
        }

        //21. метод удаление по значению первого (?вернуть индекс)
        public void RemoveByValueOne(int value)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }

            if (GetIndexByValue(value) != -1)
            {
                RemoveOneElementByIndex(GetIndexByValue(value));
            }
            else
            {
                throw new ArgumentException();
            }
        }

        //22. метод удаление по значению всех (?вернуть кол-во)
        public void RemoveByValueAll(int value)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    RemoveOneElementByIndex(i);
                }
            }
        }

        //24. метод добавление списка (вашего самодельного) в конец
        public void AddValueToTheEnd(ArrayList arrList)
        {
            AddValueByIndex(arrList, Length);
        }

        //25. метод добавление списка в начало
        public void AddValueToTheBegin(ArrayList arrList)
        {
            AddValueByIndex(arrList, 0);
        }

        //26. метод добавление списка по индексу
        public void AddValueByIndex(ArrayList arrList, int index)
        {
            int newLength = Length + arrList.Length;
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
            /*
            while (newLength >= _array.Length)
            {
                UpSize();
            }
            */
            for (int i = Length; i > index; i--)
            {
                _array[i + arrList.Length - 1] = _array[i - 1];
            }

            Length = Length + arrList.Length;

            for (int i = 0; i < arrList.Length; i++)
            {
                _array[i + index] = arrList[i];
            }
        }

        private void UpSize() // увеличение длины массива
        {
            int newLength = (int)(_array.Length * 1.33d + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        private void DownSize() //уменьшение длинны массивы
        {
            int newLength = (int)(_array.Length * 0.67d + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Length, _array);
        }
    }
}
