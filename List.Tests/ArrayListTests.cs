using List;
using NUnit.Framework;

namespace List.Tests
{
    public class Tests
    {
        //1.  ���������� �������� � �����
        [TestCase(8, "1 2 3 4 5 8 ")]
        public void AddValueToTheEndTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueToTheEnd(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //2.  ���������� �������� � ������
        [TestCase(8, "8 1 2 3 4 5 ")]
        public void AddValueToTheBeginTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueToTheBegin(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //3.  ���������� �������� �� �������
        [TestCase(8, 3, "1 2 3 8 4 5 ")]
        public void AddValueByIndexTest(int value, int index, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueByIndex(value, index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //4.  �������� �� ����� ������ ��������
        [TestCase("1 2 3 4 ")]
        public void RemoveOneElementFromTheEndTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementFromTheEnd();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //5.  �������� �� ������ ������ ��������
        [TestCase("2 3 4 5 ")]
        public void RemoveOneElementFromTheBeginTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementFromTheBegin();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //6.  �������� �� ������� ������ ��������
        [TestCase(2, "1 2 4 5 ")]
        public void RemoveOneElementByIndexTest(int index,string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementByIndex(index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //7. �������� �� ����� N ���������
        [TestCase(2, "1 2 3 ")]
        public void RemoveNElementsFromTheEndTest(int index, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveNElementsFromTheEnd(index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //8. �������� �� ������ N ���������
        [TestCase(2, "3 4 5 ")]
        public void RemoveNElementsFromTheBeginTest(int index, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveNElementsFromTheBegin(index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //9.�������� �� ������� N ���������
        [TestCase(1, 2, "1 4 5 ")]
        public void RemoveByIndexNElementsTest(int index, int n, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveByIndexNElements(index, n);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //11.  ������ �� ������� 
        [TestCase(2, 3)]
        public void GetValueByIndexTest(int index, int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int actual = arrList.GetValueByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        //12.  ������ ������ �� ��������
        [TestCase(2, 1)]
        public void GetIndexByValueTest(int value, int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 2, 5 });
            int actual = arrList.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        //13. ��������� �� �������
        [TestCase(2, 1, "1 2 1 4 5 ")]
        public void ChangeByIndexTest(int index, int value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.ChangeByIndex(index, value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //14.  ������ (123 -> 321)
        [TestCase("5 4 3 2 1 ")]
        public void ReversTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.Revers();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //15.  ����� �������� ������������� ��������
        [TestCase(5)]
        public void FindMaxValueTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });            
            int actual = arrList.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }

        //16.  ����� �������� ������������ ��������
        [TestCase(1)]
        public void FindMinValueTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int actual = arrList.FindMinValue();
            Assert.AreEqual(expected, actual);
        }

        //17. ����� ����� ������ ������������� ��������
        [TestCase(2)]
        public void FindIndexMaxValueTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 3, 9, 5, 0 });
            int actual = arrList.FindIndexMaxValue();
            Assert.AreEqual(expected, actual);
        }

        //18.  ����� ������ ������������ ��������
        [TestCase(4)]
        public void FindIndexMinValueTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 3, 9, 5, 0 });
            int actual = arrList.FindIndexMinValue();
            Assert.AreEqual(expected, actual);
        }

        //19.  ���������� �� �����������
        [TestCase("1 2 3 4 5 ")]
        public void SortAscendingTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 4, 3, 1, 5, 2 });
            arrList.SortAscending();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //20.  ���������� �� ��������
        [TestCase("5 4 3 2 1 ")]
        public void SortDescendingTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 4, 3, 1, 5, 2 });
            arrList.SortDescending();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //21.  �������� �� �������� ������� (?������� ������)
        [TestCase(3, "4 1 3 2 ")]
        public void RemoveByValueOneTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList( new int[] { 4, 3, 1, 3, 2 });
            arrList.RemoveByValueOne(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //22.  �������� �� �������� ���� (?������� ���-��)
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