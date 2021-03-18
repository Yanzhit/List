using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleList
{
    public class ArrayList
    {
        public int Length { get; private set; }  // свойство
        private int[] _array;                    // поле

        // конструктор пустой 
        public ArrayList()
        {
            Length = 0;                    //длина пользов
            _array = new int[10];          // реальная длина массива
        }

        // конструктор на основе одного элемента
        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[10];
            _array[0] = value;
        }

        // конструктор на основе массива
        public ArrayList(int[] value)
        {
            Length = value.Length;
            _array = new int[value.Length + 10];
            _array = value;
        }

        //1. метод добавление значения в конец
        public void AddValueToTheEnd(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        //2. метод добавление значения в начало
        public void AddValueToTheBegin(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            for (int i = Length; i > 0; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[0] = value;
            Length++;
        }

        //3. метод добавление значения по индексу
        public void AddValueByIndex(int value, int index)
        {
            if (Length == _array.Length)
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
            Length--;
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        //5. метод удаление из начала одного элемента
        public void RemoveOneElementFromTheBegin()
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        //6. метод удаление по индексу одного элемента
        public void RemoveOneElementByIndex(int index)
        {
            if (index > _array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        //7. удаление из конца N элементов
        public void RemoveNElementsFromTheEnd(int n)
        {

            if (n > Length)
            {
                throw new IndexOutOfRangeException();
            }
            Length -= n;
            int[] tmpArray = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        //8.удаление из начала N элементов
        public void RemoveNElementsFromTheBegin(int n)
        {
            if (n > Length)
            {
                throw new IndexOutOfRangeException();
            }
            Length -= n;
            int[] tmpArray = new int[Length];
            for (int i = Length; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        //9.удаление по индексу N элементов
        public void RemoveByIndexNElements(int index, int n)
        {
            if (n > Length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + n];
            }
            Length--;
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }

        }

        //11. метод доступ по индексу 
        public int GetValueByIndex(int index)
        {
            if (index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            return _array[index];
        }

        //12. метод первый индекс по значению
        public int GetIndexByValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        //13. метод изменение по индексу
        public void ChangeByIndex(int index, int value)
        {
            _array[index] = value;
        }

        //14. метод реверс (123 -> 321)
        public void Revers()
        {
            int tmp;
            for (int i = 0; i < Length / 2; i++)
            {
                tmp = _array[i];
                _array[i] = _array[Length / 2 - i - 1];
                _array[Length / 2 - i - 1] = tmp;
            }
        }

        //15. метод поиск значения максимального элемента
        public int FindMaxValue()
        {
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
            int max = _array[0], indexMax = 0;
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
            int min = _array[0], indexMin = 0;
            for (int i = 1; i < Length; i++)
            {
                if (min < _array[i])
                {
                    min = _array[i];
                    indexMin = i;
                }
            }
            return indexMin;
        }

        //19. метод сортировка по возрастанию
        public int[] SortAscending()
        {
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

        //20. метод сортировка по убыванию
        public int[] SortDescending()
        {
            int tmp;
            for (int i = 0; i < Length - 1; i++)
            {
                int indexOfMax = i;
                for (int j = i; j < Length; j++)
                {
                    if (_array[indexOfMax] < _array[j])
                    {
                        indexOfMax = j;
                    }
                }
                tmp = _array[i];
                _array[i] = _array[indexOfMax];
                _array[indexOfMax] = tmp;
            }
            return _array;
        }

        //21. метод удаление по значению первого (?вернуть индекс)
        public void RemoveByValueOne(int value)
        {
            RemoveOneElementByIndex(GetIndexByValue(value));
        }

        //22. метод удаление по значению всех (?вернуть кол-во)
        public void RemoveByValueAll(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                RemoveOneElementByIndex(GetIndexByValue(value));
            }
        }

        //24. метод добавление списка (вашего самодельного) в конец
        public void AddListToTheEnd()
        {
            if (Length == _array.Length)
            {
                UpSize();
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


    }
}
