using List;
using NUnit.Framework;

namespace List.Tests
{
    public class LinkedListTests
    {
        //1.  добавление значения в конец
        //      добавление значения в конец в список на основе массива
        [TestCase(8, "1 2 3 4 5 8 ")]
        public void AddValueToTheEndToListWithArrayTest(int value, string expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            linkedList.AddValueToTheEnd(value);
            string actual = linkedList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //2.  добавление значения в начало
        //      добавление значения в начало в список на основе массива
        [TestCase(8, "8 1 2 3 4 5 ")]
        public void AddValueToTheBeginToListWithArrayTest(int value, string expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            linkedList.AddValueToTheBegin(value);
            string actual = linkedList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //3.  добавление значения по индексу
        //      добавление значения по индексу в список на основе массива
        [TestCase(8, 3, "1 2 3 8 4 5 ")]
        public void AddValueByIndexToListWithArrayTest(int value, int index, string expected)
        {
            LinkedList arrList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueByIndex(value, index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //4.  удаление из конца одного элемента
        //      удаление из конца одного элемента из списка на основе массива
        [TestCase("1 2 3 4 ")]
        public void RemoveOneElementFromTheEndTest(string expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            linkedList.RemoveOneElementFromTheEnd();
            string actual = linkedList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //5.  удаление из начала одного элемента
        //      удаление из начала одного элемента из списка на основе массива
        [TestCase("2 3 4 5 ")]
        public void RemoveOneElementFromTheBeginTest(string expected)
        {
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            linkedList.RemoveOneElementFromTheBegin();
            string actual = linkedList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //6.  удаление по индексу одного элемента
        //      удаление по индексу одного элемента из списка на основе массива
        [TestCase(2, "1 2 4 5 ")]
        public void RemoveOneElementByIndexTest(int index, string expected)
        {
            LinkedList arrList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementByIndex(index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //7. удаление из конца N элементов
        //   удаление из конца N элементов из списка на основе массива
        [TestCase(2, "1 2 3 ")]
        public void RemoveNElementsFromTheEndTest(int n, string expected)
        {
            LinkedList arrList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveNElementsFromTheEnd(n);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //8. удаление из начала N элементов
        //   удаление из начала N элементов из списка на основе массива
        [TestCase(2, "3 4 5 ")]
        public void RemoveNElementsFromTheBeginTest(int n, string expected)
        {
            LinkedList arrList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveNElementsFromTheBegin(n);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //9.удаление по индексу N элементов
        [TestCase(1, 2, "1 4 5 ")]
        public void RemoveByIndexNElementsTest(int index, int n, string expected)
        {
            LinkedList arrList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveByIndexNElements(index, n);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }




    }
}
