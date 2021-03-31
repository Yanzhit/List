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
        //[TestCase()]
        //public void RemoveOneElementFromTheEndFromListWithOneElement()
        //{
        //    DoubleLinkedList dlinkedList = new DoubleLinkedList(5);
        //    DoubleLinkedList dlinkedList2 = new DoubleLinkedList();
        //    dlinkedList.RemoveOneElementFromTheEnd();
        //    Assert.AreEqual(dlinkedList, dlinkedList2);
        //}
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
        //[TestCase()]
        //public void RemoveOneElementFromTheBeginTest2()
        //{
        //    DoubleLinkedList dlinkedList = new DoubleLinkedList(5);
        //    DoubleLinkedList dlinkedList2 = new DoubleLinkedList();
        //    dlinkedList.RemoveOneElementFromTheBegin();
        //    Assert.AreEqual(dlinkedList, dlinkedList2);
        //}
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

        //13. изменение по индексу
        [TestCase(new int[] { 1, 2, 9, 4, 5 })]
        public void ChangeByIndexTest(int[] expected)
        {
            DoubleLinkedList dlinkedList = new DoubleLinkedList(new int[] { 1, 2, 3, 4, 5 });
            DoubleLinkedList dlinkedList2 = new DoubleLinkedList(expected);
            dlinkedList[2] = 9;
            Assert.AreEqual(dlinkedList, dlinkedList2);
        }


    }
}
