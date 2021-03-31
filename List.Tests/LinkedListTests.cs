using List;
using NUnit.Framework;

namespace List.Tests
{
    public class LinkedListTests
    {
        //1.  добавление значения в конец
        //      добавление значения в конец в список на основе массива
        [TestCase(8, new int[] { 1, 2, 3, 4, 5, 8 })]
        public void AddValueToTheEndToListWithArrayTest(int value, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.AddValueToTheEnd(value);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      добавление значения в конец в пустой список
        [TestCase(8, new int[] { 8 })]
        public void AddValueToTheEndToEmptyListTest(int value, int[] expected)
        {
            LinkedList linkedList = new LinkedList();
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.AddValueToTheEnd(value);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      добавление значения в конец в список с одним элементом
        [TestCase(8, new int[] { 2, 8 })]
        public void AddValueToTheEndToListWithOneElementTest(int value, int[] expected)
        {
            LinkedList linkedList = new LinkedList(2);
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.AddValueToTheEnd(value);
            Assert.AreEqual(linkedList, linkedList2);
        }

        //2.  добавление значения в начало
        //      добавление значения в начало в список на основе массива
        [TestCase(8, new int[] { 8, 1, 2, 3, 4, 5 })]
        public void AddValueToTheBeginToListWithArrayTest(int value, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.AddValueToTheBegin(value);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      добавление значения в начало в пустой список
        [TestCase(8, new int[] { 8 })]
        public void AddValueToTheBeginToEmptyListTest(int value, int[] expected)
        {
            LinkedList linkedList = new LinkedList();
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.AddValueToTheBegin(value);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      добавление значения в начало в список с одним элементом
        [TestCase(8, new int[] { 8, 5 })]
        public void AddValueToTheBeginToListWithOneElementTest(int value, int[] expected)
        {
            LinkedList linkedList = new LinkedList(5);
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.AddValueToTheBegin(value);
            Assert.AreEqual(linkedList, linkedList2);
        }

        //3.  добавление значения по индексу
        //      добавление значения по индексу в список на основе массива
        [TestCase(8, 3, new int[] { 1, 2, 3, 8, 4, 5 })]
        public void AddValueByIndexToListWithArrayTest(int value, int index, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.AddValueByIndex(value, index);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      добавление значения по индексу в пустой список
        [TestCase(8, 0, new int[] { 8 })]
        public void AddValueByIndexToEmptyListTest(int value, int index, int[] expected)
        {
            LinkedList linkedList = new LinkedList();
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.AddValueByIndex(value, index);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      добавление значения по индексу в список с одним элементом
        [TestCase(8, 0, new int[] { 8, 5 })]
        public void AddValueByIndexToListWithOneElementTest(int value, int index, int[] expected)
        {
            LinkedList linkedList = new LinkedList(5);
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.AddValueByIndex(value, index);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      проверка индекса
        [TestCase(8, 6)]
        public void AddValueByIndex_WhenIndexMoreLength_ShouldException(int value, int index)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                linkedList.AddValueByIndex(value, index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //4.  удаление из конца одного элемента
        //      удаление из конца одного элемента из списка на основе массива
        [TestCase(new int[] { 1, 2, 3, 4 })]
        public void RemoveOneElementFromTheEndTest(int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.RemoveOneElementFromTheEnd();
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      удаление из конца одного элемента из списка  с одним элементом
        [TestCase()]
        public void RemoveOneElementFromTheEndFromListWithOneElement()
        {
            LinkedList linkedList = new LinkedList(5);
            LinkedList linkedList2 = new LinkedList();
            linkedList.RemoveOneElementFromTheEnd();
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      удаление из конца одного элемента из пустого списка
        [TestCase()]
        public void RemoveOneElementFromTheEnd_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.RemoveOneElementFromTheEnd();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //5.  удаление из начала одного элемента
        //      удаление из начала одного элемента из списка на основе массива
        [TestCase(new int[] { 2, 3, 4, 5 })]
        public void RemoveOneElementFromTheBeginTest(int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.RemoveOneElementFromTheBegin();
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      удаление из начала одного элемента из списка  с одним элементом       
        [TestCase()]
        public void RemoveOneElementFromTheBeginTest2()
        {
            LinkedList linkedList = new LinkedList(5);
            LinkedList linkedList2 = new LinkedList();
            linkedList.RemoveOneElementFromTheBegin();
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      удаление  из начала одного элемента из пустого списка
        [TestCase()]
        public void RemoveOneElementFromTheBegin_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.RemoveOneElementFromTheBegin();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //6.  удаление по индексу одного элемента
        //      удаление по индексу одного элемента из списка на основе массива
        [TestCase(2, new int[] { 1, 2, 4, 5 })]
        public void RemoveOneElementByIndexTest(int index, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.RemoveOneElementByIndex(index);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      удаление по индексу одного элемента из списка с одним элементом
        [TestCase(0)]
        public void RemoveOneElementByIndexFromListWithOneElementTest(int index)
        {
            LinkedList linkedList = new LinkedList(8);
            LinkedList linkedList2 = new LinkedList();
            linkedList.RemoveOneElementByIndex(index);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      удаление по индексу одного элемента из пустого списка
        [TestCase(0)]
        public void RemoveOneElementByIndex_WhenListEmpty_ShouldException(int index)
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.RemoveOneElementByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      проверка индекса
        [TestCase(6)]
        public void RemoveOneElementByIndex_WhenIndexMoreLength_ShouldException(int index)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                linkedList.RemoveOneElementByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //7. удаление из конца N элементов
        //   удаление из конца N элементов из списка на основе массива
        [TestCase(2, new int[] { 1, 2, 3 })]
        public void RemoveNElementsFromTheEndTest(int n, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.RemoveNElementsFromTheEnd(n);
            Assert.AreEqual(linkedList, linkedList2);
        }
        // удаление из конца всех элементов
        [TestCase(5)]
        public void RemoveNElementsFromTheEndTest2(int n)
        {
            LinkedList linkedlist = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedlist2 = new LinkedList();
            linkedlist.RemoveNElementsFromTheEnd(n);
            Assert.AreEqual(linkedlist, linkedlist2);
        }
        //      проверка на пустой список
        [TestCase(10)]
        public void RemoveNElementsFromTheEnd_WhenListEmpty_ShouldException(int n)
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.RemoveNElementsFromTheEnd(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      проверка N
        [TestCase(20)]
        public void RemoveNElementsFromTheEnd_WhenNMoreLength_ShouldException(int n)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                linkedList.RemoveNElementsFromTheEnd(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //8. удаление из начала N элементов
        //   удаление из начала N элементов из списка на основе массива
        [TestCase(2, new int[] { 3, 4, 5 })]
        public void RemoveNElementsFromTheBeginTest(int n, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.RemoveNElementsFromTheBegin(n);
            Assert.AreEqual(linkedList, linkedList2);
        }
        // удаление из начала всех элементов
        [TestCase(5)]
        public void RemoveNElementsFromTheBeginTest2(int n)
        {
            LinkedList linkedlist = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedlist2 = new LinkedList();
            linkedlist.RemoveNElementsFromTheBegin(n);
            Assert.AreEqual(linkedlist, linkedlist2);
        }
        //      проверка на пустой список
        [TestCase(10)]
        public void RemoveNElementsFromTheBegin_WhenListEmpty_ShouldException(int n)
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.RemoveNElementsFromTheBegin(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      проверка N
        [TestCase(20)]
        public void RemoveNElementsFromTheBegin_WhenNMoreLength_ShouldException(int n)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                linkedList.RemoveNElementsFromTheBegin(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //9.удаление по индексу N элементов
        [TestCase(1, 2, new int[] { 1, 4, 5 })]
        public void RemoveByIndexNElementsTest(int index, int n, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.RemoveByIndexNElements(index, n);
            Assert.AreEqual(linkedList, linkedList2);
        }
        // удаление всех элементов
        [TestCase(0, 5)]
        public void RemoveByIndexNElementsTest2(int index, int n)
        {
            LinkedList linkedlist = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedlist2 = new LinkedList();
            linkedlist.RemoveByIndexNElements(index, n);
            Assert.AreEqual(linkedlist, linkedlist2);
        }
        //      проверка на пустой список
        [TestCase(0, 10)]
        public void RemoveByIndexNElements_WhenListEmpty_ShouldException(int index, int n)
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.RemoveByIndexNElements(index, n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      проверка индекса
        [TestCase(6, 2)]
        public void RemoveByIndexNElements_WhenIndexMoreLength_ShouldException(int index, int n)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                linkedList.RemoveByIndexNElements(index, n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      проверка N
        [TestCase(3, 10)]
        public void RemoveByIndexNElements_WhenNMoreLength_ShouldException(int index, int n)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                linkedList.RemoveByIndexNElements(index, n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //11.  доступ по индексу 
        //      доступ по индексу из списка на основе массива
        [TestCase(3)]
        public void GetValueByIndexFromArrayListTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(linkedList[2], expected);
        }
        //      проверка индекса
        [TestCase()]
        public void GetValueByIndex_WhenIndexMoreLength_ShouldException()
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                int actual = linkedList[10];
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      проверка на пустой список
        [TestCase()]
        public void GetValueByIndex_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                int actual = linkedList[0];
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //12.  первый индекс по значению
        [TestCase(2, 1)]
        public void GetIndexByValueTest(int value, int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 2, 5 });
            int actual = linkedList.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase(5)]
        public void GetIndexByValue_WhenListEmpty_ShouldException(int value)
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                int actual = linkedList.GetIndexByValue(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //13. изменение по индексу
        [TestCase(new int[] { 1, 2, 9, 4, 5 })]
        public void ChangeByIndexTest(int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList[2] = 9;
            Assert.AreEqual(linkedList, linkedList2);
        }

        //14.  реверс (123 -> 321)
        [TestCase(new int[] { 5, 4, 3, 2, 1 })]
        public void ReversLinkedListTest(int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.Revers();
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      проверка на пустой список
        [TestCase()]
        public void ReversList_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.Revers();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //15.  поиск значения максимального элемента
        [TestCase(5)]
        public void FindMaxValueFromArrayListTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int actual = linkedList.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase()]
        public void FindMaxValue_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.FindMaxValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //16.  поиск значения минимального элемента
        [TestCase(1)]
        public void FindMinValueFromArrayListTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int actual = linkedList.FindMinValue();
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase()]
        public void FindMinValue_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.FindMinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //17. метод поиск индекс максимального элемента
        [TestCase(2)]
        public void FindIndexMaxValueTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 3, 9, 5, 0 });
            int actual = linkedList.FindIndexMaxValue();
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase()]
        public void FindIndexMaxValue_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.FindIndexMaxValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //18.  поиск индекс минимального элемента
        [TestCase(4)]
        public void FindIndexMinValueTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 3, 9, 5, 0 });
            int actual = linkedList.FindIndexMinValue();
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase()]
        public void FindIndexMinValue_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.FindIndexMinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //19.  сортировка по возрастанию
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        public void SortAscendingTest(int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 4, 3, 1, 5, 2 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.SortAscending();
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      проверка на пустой список
        [TestCase()]
        public void SortAscending_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.SortAscending();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //20.  сортировка по убыванию
        [TestCase(new int[] { 5, 4, 3, 2, 1 })]
        public void SortDescendingTest(int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 4, 3, 1, 5, 2 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.SortDescending();
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      проверка на пустой список
        [TestCase()]
        public void SortDescending_WhenListEmpty_ShouldException()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.SortDescending();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //21.  удаление по значению первого (?вернуть индекс)
        [TestCase(3, new int[] { 4, 1, 3, 2 })]
        public void RemoveByValueOneTest(int value, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 4, 3, 1, 3, 2 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.RemoveByValueOne(value);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      проверка на пустой список
        [TestCase(3)]
        public void RemoveByValueOne_WhenListEmpty_ShouldException(int value)
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.RemoveByValueOne(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //22.  удаление по значению всех (?вернуть кол-во)
        [TestCase(3, new int[] { 4, 1, 2 })]
        public void RemoveByValueAllTest(int value, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 4, 3, 1, 3, 2 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.RemoveByValueAll(value);
            Assert.AreEqual(linkedList, linkedList2);
        }
        //      проверка на пустой список
        [TestCase(3)]
        public void RemoveByValueAll_WhenListEmpty_ShouldException(int value)
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.RemoveByValueAll(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //24.  добавление списка (вашего самодельного) в конец
        [TestCase(new int[] { 3, 3, 3, 2 }, new int[] { 3, 5, 6, 8, 2, 1, 3, 3, 3, 2 })]
        public void AddListToTheEndTest(int[] value, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 3, 5, 6, 8, 2, 1 });
            LinkedList linkedList2 = new LinkedList(expected);
            LinkedList linkedList3 = new LinkedList(value);
            linkedList.AddValueToTheEnd(linkedList3);
            Assert.AreEqual(linkedList, linkedList2);
        }

        //25.  добавление списка в начало
        [TestCase(new int[] { 3, 3, 3, 2 }, new int[] { 3, 3, 3, 2, 3, 5, 6, 8, 2, 1 })]
        public void AddListToTheBeginTest(int[] value, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 3, 5, 6, 8, 2, 1 });
            LinkedList linkedList2 = new LinkedList(expected);
            LinkedList linkedList3 = new LinkedList(value);
            linkedList.AddValueToTheBegin(linkedList3);
            Assert.AreEqual(linkedList, linkedList2);
        }

        //26.  добавление списка по индексу
        [TestCase(new int[] { 3, 3, 3, 2 }, 2, new int[] { 3, 5, 3, 3, 3, 2, 6, 8, 2, 1 })]
        public void AddListByIndexTest(int[] value, int index, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 3, 5, 6, 8, 2, 1 });
            LinkedList linkedList2 = new LinkedList(expected);
            LinkedList linkedList3 = new LinkedList(value);
            linkedList.AddValueByIndex(linkedList3, index);
            Assert.AreEqual(linkedList, linkedList2);
        }

    }
}
