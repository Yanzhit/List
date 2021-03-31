using List;
using NUnit.Framework;

namespace List.Tests
{
    public class DoubleLinkedListTests
    {
        //1.  добавление значения в конец
        //      добавление значения в конец в список на основе массива
        [TestCase(8, new int[] { 1, 2, 3, 4, 5, 8 })]
        public void AddValueToTheEndToListWithArrayTest(int value, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.AddValueToTheEnd(value);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      добавление значения в конец в пустой список
        [TestCase(8, new int[] { 8 })]
        public void AddValueToTheEndToEmptyListTest(int value, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.AddValueToTheEnd(value);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      добавление значения в конец в список с одним элементом
        [TestCase(8, new int[] { 2, 8 })]
        public void AddValueToTheEndToListWithOneElementTest(int value, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(2);
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.AddValueToTheEnd(value);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }

        //2.  добавление значения в начало
        //      добавление значения в начало в список на основе массива
        [TestCase(8, new int[] { 8, 1, 2, 3, 4, 5 })]
        public void AddValueToTheBeginToListWithArrayTest(int value, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.AddValueToTheBegin(value);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      добавление значения в начало в пустой список
        [TestCase(8, new int[] { 8 })]
        public void AddValueToTheBeginToEmptyListTest(int value, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.AddValueToTheBegin(value);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      добавление значения в начало в список с одним элементом
        [TestCase(8, new int[] { 8, 5 })]
        public void AddValueToTheBeginToListWithOneElementTest(int value, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(5);
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.AddValueToTheBegin(value);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }

        //3.  добавление значения по индексу
        //      добавление значения по индексу в список на основе массива
        [TestCase(8, 3, new int[] { 1, 2, 3, 8, 4, 5 })]
        public void AddValueByIndexToListWithArrayTest(int value, int index, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.AddValueByIndex(value, index);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      добавление значения по индексу в пустой список
        [TestCase(8, 0, new int[] { 8 })]
        public void AddValueByIndexToEmptyListTest(int value, int index, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.AddValueByIndex(value, index);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      добавление значения по индексу в список с одним элементом
        [TestCase(8, 0, new int[] { 8, 5 })]
        public void AddValueByIndexToListWithOneElementTest(int value, int index, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(5);
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.AddValueByIndex(value, index);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      проверка индекса
        [TestCase(8, 6)]
        public void AddValueByIndex_WhenIndexMoreLength_ShouldException(int value, int index)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                dlinkedList.AddValueByIndex(value, index);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.RemoveOneElementFromTheEnd();
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        ////      удаление из конца одного элемента из списка  с одним элементом
        [TestCase()]
        public void RemoveOneElementFromTheEndFromListWithOneElement()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(5);
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList();
            dlinkedList.RemoveOneElementFromTheEnd();
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      удаление из конца одного элемента из пустого списка
        [TestCase()]
        public void RemoveOneElementFromTheEnd_WhenListEmpty_ShouldException()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.RemoveOneElementFromTheEnd();
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.RemoveOneElementFromTheBegin();
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        ////      удаление из начала одного элемента из списка  с одним элементом       
        [TestCase()]
        public void RemoveOneElementFromTheBeginTest2()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(5);
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList();
            dlinkedList.RemoveOneElementFromTheBegin();
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      удаление  из начала одного элемента из пустого списка
        [TestCase()]
        public void RemoveOneElementFromTheBegin_WhenListEmpty_ShouldException()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.RemoveOneElementFromTheBegin();
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.RemoveOneElementByIndex(index);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      удаление по индексу одного элемента из списка с одним элементом
        [TestCase(0)]
        public void RemoveOneElementByIndexFromListWithOneElementTest(int index)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(8);
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList();
            dlinkedList.RemoveOneElementByIndex(index);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      удаление по индексу одного элемента из пустого списка
        [TestCase(0)]
        public void RemoveOneElementByIndex_WhenListEmpty_ShouldException(int index)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.RemoveOneElementByIndex(index);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                dlinkedList.RemoveOneElementByIndex(index);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.RemoveNElementsFromTheEnd(n);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        // удаление из конца всех элементов
        [TestCase(5)]
        public void RemoveNElementsFromTheEndTest2(int n)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList();
            dlinkedList.RemoveNElementsFromTheEnd(n);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      проверка на пустой список
        [TestCase(10)]
        public void RemoveNElementsFromTheEnd_WhenListEmpty_ShouldException(int n)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.RemoveNElementsFromTheEnd(n);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                dlinkedList.RemoveNElementsFromTheEnd(n);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.RemoveNElementsFromTheBegin(n);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        // удаление из начала всех элементов
        [TestCase(5)]
        public void RemoveNElementsFromTheBeginTest2(int n)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList();
            dlinkedList.RemoveNElementsFromTheBegin(n);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      проверка на пустой список
        [TestCase(10)]
        public void RemoveNElementsFromTheBegin_WhenListEmpty_ShouldException(int n)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.RemoveNElementsFromTheBegin(n);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                dlinkedList.RemoveNElementsFromTheBegin(n);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.RemoveByIndexNElements(index, n);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        // удаление всех элементов
        [TestCase(0, 5)]
        public void RemoveByIndexNElementsTest2(int index, int n)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList();
            dlinkedList.RemoveByIndexNElements(index, n);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      проверка на пустой список
        [TestCase(0, 10)]
        public void RemoveByIndexNElements_WhenListEmpty_ShouldException(int index, int n)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.RemoveByIndexNElements(index, n);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                dlinkedList.RemoveByIndexNElements(index, n);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                dlinkedList.RemoveByIndexNElements(index, n);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(dlinkedList[2], expected);
        }
        //      проверка индекса
        [TestCase()]
        public void GetValueByIndex_WhenIndexMoreLength_ShouldException()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                int actual = dlinkedList[10];
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                int actual = dlinkedList[0];
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 2, 5 });
            int actual = dlinkedList.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase(5)]
        public void GetIndexByValue_WhenListEmpty_ShouldException(int value)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                int actual = dlinkedList.GetIndexByValue(value);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList[2] = 9;
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }

        //14.  реверс(123 -> 321)
        [TestCase(new int[] { 5, 4, 3, 2, 1 })]
        public void ReversLinkedListTest(int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.Revers();
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      проверка на пустой список
        [TestCase()]
        public void ReversList_WhenListEmpty_ShouldException()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.Revers();
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            int actual = dlinkedList.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase()]
        public void FindMaxValue_WhenListEmpty_ShouldException()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.FindMaxValue();
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            int actual = dlinkedList.FindMinValue();
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase()]
        public void FindMinValue_WhenListEmpty_ShouldException()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.FindMinValue();
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 3, 9, 5, 0 });
            int actual = dlinkedList.FindIndexMaxValue();
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase()]
        public void FindIndexMaxValue_WhenListEmpty_ShouldException()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.FindIndexMaxValue();
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 3, 9, 5, 0 });
            int actual = dlinkedList.FindIndexMinValue();
            Assert.AreEqual(expected, actual);
        }
        //      проверка на пустой список
        [TestCase()]
        public void FindIndexMinValue_WhenListEmpty_ShouldException()
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.FindIndexMinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        ////19.  сортировка по возрастанию
        //[TestCase(new int[] { 1, 2, 3, 4, 5 })]
        //public void SortAscendingTest(int[] expected)
        //{
        //    DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 4, 3, 1, 5, 2 });
        //    DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
        //    dlinkedList.SortAscending();
        //    Assert.AreEqual(dlinkedList, dlinkedList2);
        //}
        ////      проверка на пустой список
        //[TestCase()]
        //public void SortAscending_WhenListEmpty_ShouldException()
        //{
        //    DoubleLinkedList dlinkedList = new DoubleLinkedList();
        //    try
        //    {
        //        dlinkedList.SortAscending();
        //    }
        //    catch
        //    {
        //        Assert.Pass();
        //    }
        //    Assert.Fail();
        //}

        ////20.  сортировка по убыванию
        //[TestCase(new int[] { 5, 4, 3, 2, 1 })]
        //public void SortDescendingTest(int[] expected)
        //{
        //    DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 4, 3, 1, 5, 2 });
        //    DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
        //    dlinkedList.SortDescending();
        //    Assert.AreEqual(dlinkedList, dlinkedList2);
        //}
        ////      проверка на пустой список
        //[TestCase()]
        //public void SortDescending_WhenListEmpty_ShouldException()
        //{
        //    DoubleLinkedList dlinkedList = new DoubleLinkedList();
        //    try
        //    {
        //        dlinkedList.SortDescending();
        //    }
        //    catch
        //    {
        //        Assert.Pass();
        //    }
        //    Assert.Fail();
        //}

        //21.  удаление по значению первого (?вернуть индекс)
        [TestCase(3, new int[] { 4, 1, 3, 2 })]
        public void RemoveByValueOneTest(int value, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 4, 3, 1, 3, 2 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.RemoveByValueOne(value);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      проверка на пустой список
        [TestCase(3)]
        public void RemoveByValueOne_WhenListEmpty_ShouldException(int value)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.RemoveByValueOne(value);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 4, 3, 1, 3, 2 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList.RemoveByValueAll(value);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }
        //      проверка на пустой список
        [TestCase(3)]
        public void RemoveByValueAll_WhenListEmpty_ShouldException(int value)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList();
            try
            {
                dlinkedList.RemoveByValueAll(value);
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
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 3, 5, 6, 8, 2, 1 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            DoubleLinkedList dlinkedList3 = new DoubleLinkedList(value);
            dlinkedList.AddValueToTheEnd(dlinkedList3);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }

        //25.  добавление списка в начало
        [TestCase(new int[] { 3, 3, 3, 2 }, new int[] { 3, 3, 3, 2, 3, 5, 6, 8, 2, 1 })]
        public void AddListToTheBeginTest(int[] value, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 3, 5, 6, 8, 2, 1 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            DoubleLinkedList dlinkedList3 = new DoubleLinkedList(value);
            dlinkedList.AddValueToTheBegin(dlinkedList3);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }

        //26.  добавление списка по индексу
        [TestCase(new int[] { 3, 3, 3, 2 }, 2, new int[] { 3, 5, 3, 3, 3, 2, 6, 8, 2, 1 })]
        public void AddListByIndexTest(int[] value, int index, int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 3, 5, 6, 8, 2, 1 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            DoubleLinkedList dlinkedList3 = new DoubleLinkedList(value);
            dlinkedList.AddValueByIndex(dlinkedList3, index);
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }



    }
}
