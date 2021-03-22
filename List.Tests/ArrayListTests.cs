using List;
using NUnit.Framework;

namespace List.Tests
{
    public class Tests
    {
        //1.  ���������� �������� � �����
        //      ���������� �������� � ����� � ������ �� ������ �������
        [TestCase(8, "1 2 3 4 5 8 ")]
        public void AddValueToTheEndToListWithArrayTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueToTheEnd(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      ���������� �������� � ����� � ������ ������
        [TestCase(8, "8 ")]
        public void AddValueToTheEndToEmptyListTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList();
            arrList.AddValueToTheEnd(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      ���������� �������� � ����� � ������ � ����� ���������
        [TestCase(8, "2 8 ")]
        public void AddValueToTheEndToListWithOneElementTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList(2);
            arrList.AddValueToTheEnd(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //2.  ���������� �������� � ������
        //      ���������� �������� � ������ � ������ �� ������ �������
        [TestCase(8, "8 1 2 3 4 5 ")]
        public void AddValueToTheBeginToListWithArrayTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueToTheBegin(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      ���������� �������� � ������ � ������ ������
        [TestCase(8, "8 ")]
        public void AddValueToTheBeginToEmptyListTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList();
            arrList.AddValueToTheBegin(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      ���������� �������� � ������ � ������ � ����� ���������
        [TestCase(8, "8 5 ")]
        public void AddValueToTheBeginToListWithOneElementTest(int value, string expected)
        {
            ArrayList arrList = new ArrayList(5);
            arrList.AddValueToTheBegin(value);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //3.  ���������� �������� �� �������
        //      ���������� �������� �� ������� � ������ �� ������ �������
        [TestCase(8, 3, "1 2 3 8 4 5 ")]
        public void AddValueByIndexToListWithArrayTest(int value, int index, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.AddValueByIndex(value, index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      ���������� �������� �� ������� � ������ ������
        [TestCase(8, 0, "8 ")]
        public void AddValueByIndexToEmptyListTest(int value, int index, string expected)
        {
            ArrayList arrList = new ArrayList();
            arrList.AddValueByIndex(value, index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      ���������� �������� �� ������� � ������ � ����� ���������
        [TestCase(8, 0, "8 5 ")]
        public void AddValueByIndexToListWithOneElementTest(int value, int index, string expected)
        {
            ArrayList arrList = new ArrayList(5);
            arrList.AddValueByIndex(value, index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �������
        [TestCase(8, 6)]
        public void AddValueByIndex_WhenIndexMoreLength_ShouldException(int value, int index)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                arrList.AddValueByIndex(value, index);
            }
            catch 
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //4.  �������� �� ����� ������ ��������
        //      �������� �� ����� ������ �������� �� ������ �� ������ �������
        [TestCase("1 2 3 4 ")]
        public void RemoveOneElementFromTheEndTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementFromTheEnd();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ����� ������ �������� �� ������  � ����� ���������
        /*
        [TestCase(null)]
        public void RemoveOneElementFromTheEndTest2(string expected)
        {
            ArrayList arrList = new ArrayList(5);
            arrList.RemoveOneElementFromTheEnd();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        */
        //      �������� �� ����� ������ �������� �� ������� ������
        [TestCase(0)]
        public void RemoveOneElementFromTheEnd_WhenListEmpty_ShouldException(int index)
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.RemoveOneElementFromTheEnd();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //5.  �������� �� ������ ������ ��������
        //      �������� �� ������ ������ �������� �� ������ �� ������ �������
        [TestCase("2 3 4 5 ")]
        public void RemoveOneElementFromTheBeginTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementFromTheBegin();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ������ ������ �������� �� ������  � ����� ���������
        /*
        [TestCase(null)]
        public void RemoveOneElementFromTheBeginTest(string expected)
        {
            ArrayList arrList = new ArrayList(5);
            arrList.RemoveOneElementFromTheBegin();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        */
        //      ��������  �� ������ ������ �������� �� ������� ������
        [TestCase(0)]
        public void RemoveOneElementFromTheBegin_WhenListEmpty_ShouldException(int index)
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.RemoveOneElementFromTheBegin();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //6.  �������� �� ������� ������ ��������
        //      �������� �� ������� ������ �������� �� ������ �� ������ �������
        [TestCase(2, "1 2 4 5 ")]
        public void RemoveOneElementByIndexTest(int index,string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveOneElementByIndex(index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        /*
        //      �������� �� ������� ������ �������� �� ������ � ����� ���������
        [TestCase(0, "")]
        public void RemoveOneElementByIndexFromListWithOneElementTest(int index, string expected)
        {
            ArrayList arrList = new ArrayList(8);
            arrList.RemoveOneElementByIndex(index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        */
        //      �������� �� ������� ������ �������� �� ������� ������
        [TestCase(0)]
        public void RemoveOneElementByIndex_WhenListEmpty_ShouldException(int index)
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.RemoveOneElementByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      �������� �������
        [TestCase(6)]
        public void RemoveOneElementByIndex_WhenIndexMoreLength_ShouldException(int index)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                arrList.RemoveOneElementByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //7. �������� �� ����� N ���������
        //   �������� �� ����� N ��������� �� ������ �� ������ �������
        [TestCase(2, "1 2 3 ")]
        public void RemoveNElementsFromTheEndTest(int n, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveNElementsFromTheEnd(n);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ������ ������
        [TestCase(10)]
        public void RemoveNElementsFromTheEnd_WhenListEmpty_ShouldException(int n)
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.RemoveNElementsFromTheEnd(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      �������� N
        [TestCase(20)]
        public void RemoveNElementsFromTheEnd_WhenNMoreLength_ShouldException(int n)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                arrList.RemoveNElementsFromTheEnd(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //8. �������� �� ������ N ���������
        //   �������� �� ������ N ��������� �� ������ �� ������ �������
        [TestCase(2, "3 4 5 ")]
        public void RemoveNElementsFromTheBeginTest(int n, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.RemoveNElementsFromTheBegin(n);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ������ ������
        [TestCase(10)]
        public void RemoveNElementsFromTheBegin_WhenListEmpty_ShouldException(int n)
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.RemoveNElementsFromTheBegin(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      �������� N
        [TestCase(20)]
        public void RemoveNElementsFromTheBegin_WhenNMoreLength_ShouldException(int n)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                arrList.RemoveNElementsFromTheBegin(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
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
        //      �������� �� ������ ������
        [TestCase(0, 10)]
        public void RemoveByIndexNElements_WhenListEmpty_ShouldException(int index, int n)
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.RemoveByIndexNElements(index, n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      �������� �������
        [TestCase(6,2)]
        public void RemoveByIndexNElements_WhenIndexMoreLength_ShouldException(int index, int n)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                arrList.RemoveByIndexNElements(index, n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      �������� N
        [TestCase(3,10)]
        public void RemoveByIndexNElements_WhenNMoreLength_ShouldException(int index, int n)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                arrList.RemoveByIndexNElements(index, n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //11.  ������ �� ������� 
        //      ������ �� ������� �� ������ �� ������ �������
        [TestCase(3)]
        public void GetValueByIndexFromArrayListTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int actual = arrList[2];
            Assert.AreEqual(expected, actual);
        }
        //      ������ �� ������� �� ������ �� ������ ��������
        [TestCase(3)]
        public void GetValueByIndexFromListWithOneElementTest(int expected)
        {
            ArrayList arrList = new ArrayList(3);
            int actual = arrList[0];
            Assert.AreEqual(expected, actual);
        }
        //      �������� �������
        [TestCase()]
        public void GetValueByIndex_WhenIndexMoreLength_ShouldException()
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                int actual = arrList[10];
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      �������� �� ������ ������
        [TestCase()]
        public void GetValueByIndex_WhenListEmpty_ShouldException()
        {
            ArrayList arrList = new ArrayList();
            try
            {
                int actual = arrList[0];
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //12.  ������ ������ �� ��������
        [TestCase(2, 1)]
        public void GetIndexByValueTest(int value, int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 2, 5 });
            int actual = arrList.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(7, -1)]
        public void GetIndexByValueWhenValueNotInListTest(int value, int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 2, 5 });
            int actual = arrList.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ������ ������
        [TestCase(5)]
        public void GetIndexByValue_WhenListEmpty_ShouldException(int value)
        {
            ArrayList arrList = new ArrayList();
            try
            {
                int actual = arrList.GetIndexByValue(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //13. ��������� �� �������
        [TestCase("1 2 9 4 5 ")]
        public void ChangeByIndexTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList[2]=9;
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //14.  ������ (123 -> 321)
        [TestCase("5 4 3 2 1 ")]
        public void ReversArrayListTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            arrList.Revers();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase("8 ")]
        public void ReversListFromOneElementTest(string expected)
        {
            ArrayList arrList = new ArrayList(8);
            arrList.Revers();
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ������ ������
        [TestCase()]
        public void ReversList_WhenListEmpty_ShouldException()
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.Revers();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //15.  ����� �������� ������������� ��������
        [TestCase(5)]
        public void FindMaxValueFromArrayListTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });            
            int actual = arrList.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(9)]
        public void FindMaxValueFromListWithOneElementsTest(int expected)
        {
            ArrayList arrList = new ArrayList(9);
            int actual = arrList.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ������ ������
        [TestCase()]
        public void FindMaxValue_WhenListEmpty_ShouldException()
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.FindMaxValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //16.  ����� �������� ������������ ��������
        [TestCase(1)]
        public void FindMinValueFromArrayListTest(int expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int actual = arrList.FindMinValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(7)]
        public void FindMinValueFromListWithOneElementTest(int expected)
        {
            ArrayList arrList = new ArrayList(7);
            int actual = arrList.FindMinValue();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ������ ������
        [TestCase()]
        public void FindMinValue_WhenListEmpty_ShouldException()
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.FindMinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //17. ����� ����� ������ ������������� ��������
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
        //      �������� �� ������ ������
        [TestCase()]
        public void FindIndexMaxValue_WhenListEmpty_ShouldException()
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.FindIndexMaxValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //18.  ����� ������ ������������ ��������
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
        //      �������� �� ������ ������
        [TestCase()]
        public void FindIndexMinValue_WhenListEmpty_ShouldException()
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.FindIndexMinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //19.  ���������� �� �����������
        [TestCase("1 2 3 4 5 ")]
        public void SortAscendingTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 4, 3, 1, 5, 2 });
            int left = 0;
            int right = arrList.Length - 1;
            arrList.SortAscending(left, right);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase("34 ")]
        public void SortAscendingTest2(string expected)
        {
            ArrayList arrList = new ArrayList(34);
            int left = 0;
            int right = arrList.Length - 1;
            arrList.SortAscending(left, right);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ������ ������
        [TestCase()]
        public void SortAscending_WhenListEmpty_ShouldException()
        {
            ArrayList arrList = new ArrayList();
            try
            {
                int left = 0;
                int right = arrList.Length - 1;
                arrList.SortAscending(left, right);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //20.  ���������� �� ��������
        [TestCase("5 4 3 2 1 ")]
        public void SortDescendingTest(string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 4, 3, 1, 5, 2 });
            int left = 0;
            int right = arrList.Length - 1;
            arrList.SortDescending(left, right);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestCase("25 ")]
        public void SortDescendingTest2(string expected)
        {
            ArrayList arrList = new ArrayList(25);
            int left = 0;
            int right = arrList.Length - 1;
            arrList.SortDescending(left, right);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }
        //      �������� �� ������ ������
        [TestCase()]
        public void SortDescending_WhenListEmpty_ShouldException()
        {
            ArrayList arrList = new ArrayList();
            try
            {
                int left = 0;
                int right = arrList.Length - 1;
                arrList.SortDescending(left, right);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
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
        [TestCase(5)]
        public void RemoveByValueOne_WhenValueNotInList_ShouldException(int value)
        {
            ArrayList arrList = new ArrayList(new int[] { 4, 3, 1, 3, 2 });
            try
            {
                arrList.RemoveByValueOne(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        //      �������� �� ������ ������
        [TestCase(3)]
        public void RemoveByValueOne_WhenListEmpty_ShouldException(int value)
        {
            ArrayList arrList = new ArrayList();
            try
            {
                arrList.RemoveByValueOne(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
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

        //24.  ���������� ������ (������ ������������) � �����
        [TestCase(new int[] { 3, 3, 3, 2 }, "3 5 6 8 2 1 3 3 3 2 ")]
        public void AddListToTheEndTest(int[] value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 3, 5, 6, 8, 2, 1 });
            ArrayList arrList2 = new ArrayList(value);
            arrList.AddValueToTheEnd(arrList2);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //25.  ���������� ������ � ������
        [TestCase(new int[] { 3, 3, 3, 2 }, "3 3 3 2 3 5 6 8 2 1 ")]
        public void AddListToTheBeginTest(int[] value, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 3, 5, 6, 8, 2, 1 });
            ArrayList arrList2 = new ArrayList(value);
            arrList.AddValueToTheBegin(arrList2);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }


        //26.  ���������� ������ �� �������
        [TestCase(new int[] {3, 3, 3, 2}, 2, "3 5 3 3 3 2 6 8 2 1 ")]
        public void AddListByIndexTest(int[] value, int index, string expected)
        {
            ArrayList arrList = new ArrayList(new int[] { 3, 5, 6, 8, 2, 1 });
            ArrayList arrList2 = new ArrayList(value);
            arrList.AddValueByIndex(arrList2, index);
            string actual = arrList.ToString();
            Assert.AreEqual(expected, actual);
        }       
    }
}