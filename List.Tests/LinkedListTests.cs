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

        //9.удаление по индексу N элементов
        [TestCase(1, 2, new int[] { 1, 4, 5 })]
        public void RemoveByIndexNElementsTest(int index, int n, int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.RemoveByIndexNElements(index, n);
            Assert.AreEqual(linkedList, linkedList2);
        }

        //11.  доступ по индексу 
        //      доступ по индексу из списка на основе массива
        [TestCase(3)]
        public void GetValueByIndexFromArrayListTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(linkedList[2], expected);
        }

        //12.  первый индекс по значению
        [TestCase(2, 1)]
        public void GetIndexByValueTest(int value, int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 2, 5 });
            int actual = linkedList.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
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
        public void ReversArrayListTest(int[] expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList linkedList2 = new LinkedList(expected);
            linkedList.Revers();
            Assert.AreEqual(linkedList, linkedList2);
        }

        //15.  поиск значения максимального элемента
        [TestCase(5)]
        public void FindMaxValueFromArrayListTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int actual = linkedList.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }

        //16.  поиск значения минимального элемента
        [TestCase(1)]
        public void FindMinValueFromArrayListTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int actual = linkedList.FindMinValue();
            Assert.AreEqual(expected, actual);
        }

        //17. метод поиск индекс максимального элемента
        [TestCase(2)]
        public void FindIndexMaxValueTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 3, 9, 5, 0 });
            int actual = linkedList.FindIndexMaxValue();
            Assert.AreEqual(expected, actual);
        }

        //18.  поиск индекс минимального элемента
        [TestCase(4)]
        public void FindIndexMinValueTest(int expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 3, 9, 5, 0 });
            int actual = linkedList.FindIndexMinValue();
            Assert.AreEqual(expected, actual);
        }


    }
}
