using List;
using NUnit.Framework;

namespace List.Tests
{
    public class Tests
    {
        //1.  добавление значения в конец
        [TestCase(8, "1 2 3 4 5 8 ")]
        public void AddValueToTheEndTest1(int value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueToTheEnd(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, "8 ")]
        public void AddValueToTheEndTest2(int value, string expected)
        {
            ArrayList arrList = new ArrayList();
            arrList.AddValueToTheEnd(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, "2 8 ")]
        public void AddValueToTheEndTest3(int value, string expected)
        {
            ArrayList arrList = new ArrayList(2);
            arrList.AddValueToTheEnd(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //2.  добавление значения в начало
        [TestCase(8, "8 1 2 3 4 5 ")]
        public void AddValueToTheBeginTest1(int value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueToTheBegin(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, "8 ")]
        public void AddValueToTheBeginTest2(int value, string expected)
        {
            ArrayList arrList = new ArrayList();
            arrList.AddValueToTheBegin(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, "8 5 ")]
        public void AddValueToTheBeginTest3(int value, string expected)
        {
            ArrayList arrList = new ArrayList(5);
            arrList.AddValueToTheBegin(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //3.  добавление значения по индексу
        [TestCase(8, 3, "1 2 3 8 4 5 ")]
        public void AddValueByIndexTest1(int value, int index, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueByIndex(value, index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, 0, "8 ")]
        public void AddValueByIndexTest2(int value, int index, string expected)
        {
            ArrayList arrList = new ArrayList();
            arrList.AddValueByIndex(value, index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, 0, "8 5 ")]
        public void AddValueByIndexTest3(int value, int index, string expected)
        {
            ArrayList arrList = new ArrayList(5);
            arrList.AddValueByIndex(value, index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //4.  удаление из конца одного элемента
        [TestCase("1 2 3 4 ")]
        public void RemoveOneElementFromTheEndTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementFromTheEnd();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //5.  удаление из начала одного элемента
        [TestCase("2 3 4 5 ")]
        public void RemoveOneElementFromTheBeginTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementFromTheBegin();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //6.  удаление по индексу одного элемента
        [TestCase(2, "1 2 4 5 ")]
        public void RemoveOneElementByIndexTest(int index,string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementByIndex(index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //7. удаление из конца N элементов
        [TestCase(2, "1 2 3 ")]
        public void RemoveNElementsFromTheEndTest(int index, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveNElementsFromTheEnd(index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //8. удаление из начала N элементов
        [TestCase(2, "3 4 5 ")]
        public void RemoveNElementsFromTheBeginTest(int index, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveNElementsFromTheBegin(index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //9.удаление по индексу N элементов
        [TestCase(1, 2, "1 4 5 ")]
        public void RemoveByIndexNElementsTest(int index, int n, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveByIndexNElements(index, n);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //11.  доступ по индексу 
        [TestCase(2, 3)]
        public void GetValueByIndexTest(int index, int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int actual = arrList.GetValueByIndex(index);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 3)]
        public void GetValueByIndexTest2(int index, int expected)
        {
            ArrayList arrList = new ArrayList(3);
            int actual = arrList.GetValueByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        //12.  первый индекс по значению
        [TestCase(2, 1)]
        public void GetIndexByValueTest(int value, int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 2, 5 });
            int actual = arrList.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        //13. изменение по индексу
        [TestCase(2, 1, "1 2 1 4 5 ")]
        public void ChangeByIndexTest(int index, int value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.ChangeByIndex(index, value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //14.  реверс (123 -> 321)
        [TestCase("5 4 3 2 1 ")]
        public void ReversTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.Revers();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase("8 ")]
        public void ReversTest2(string expected)
        {
            ArrayList arrList = new ArrayList(8);
            arrList.Revers();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //15.  поиск значения максимального элемента
        [TestCase(5)]
        public void FindMaxValueTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });            
            int actual = arrList.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(9)]
        public void FindMaxValueTest2(int expected)
        {
            ArrayList arrList = new ArrayList(9);
            int actual = arrList.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }

        //16.  поиск значения минимального элемента
        [TestCase(1)]
        public void FindMinValueTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int actual = arrList.FindMinValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(7)]
        public void FindMinValueTest2(int expected)
        {
            ArrayList arrList = new ArrayList(7);
            int actual = arrList.FindMinValue();
            Assert.AreEqual(expected, actual);
        }

        //17. метод поиск индекс максимального элемента
        [TestCase(2)]
        public void FindIndexMaxValueTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 3, 9, 5, 0 });
            int actual = arrList.FindIndexMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        public void FindIndexMaxValueTest2(int expected)
        {
            ArrayList arrList = new ArrayList(7);
            int actual = arrList.FindIndexMaxValue();
            Assert.AreEqual(expected, actual);
        }

        //18.  поиск индекс минимального элемента
        [TestCase(4)]
        public void FindIndexMinValueTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 3, 9, 5, 0 });
            int actual = arrList.FindIndexMinValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        public void FindIndexMinValueTest2(int expected)
        {
            ArrayList arrList = new ArrayList(2);
            int actual = arrList.FindIndexMinValue();
            Assert.AreEqual(expected, actual);
        }

        //19.  сортировка по возрастанию
        [TestCase("1 2 3 4 5 ")]
        public void SortAscendingTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 4, 3, 1, 5, 2 });
            arrList.SortAscending();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase("34 ")]
        public void SortAscendingTest2(string expected)
        {
            ArrayList arrList = new ArrayList(34);
            arrList.SortAscending();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //20.  сортировка по убыванию
        [TestCase("5 4 3 2 1 ")]
        public void SortDescendingTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 4, 3, 1, 5, 2 });
            arrList.SortDescending();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase("25 ")]
        public void SortDescendingTest2(string expected)
        {
            ArrayList arrList = new ArrayList(25);
            arrList.SortDescending();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //21.  удаление по значению первого (?вернуть индекс)
        [TestCase(3, "4 1 3 2 ")]
        public void RemoveByValueOneTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList( new int[] { 4, 3, 1, 3, 2 });
            arrList.RemoveByValueOne(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //22.  удаление по значению всех (?вернуть кол-во)
        [TestCase(3, "4 1 2 ")]
        public void RemoveByValueAllTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 4, 3, 1, 3, 2 });
            arrList.RemoveByValueAll(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }


    }
}