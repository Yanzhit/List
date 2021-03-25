using System;

namespace List
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList(new int[] { 4, 9, 7, 6, 2, 3, 8 });
            Console.WriteLine(arrList);           
            ArrayList arrList2 = new ArrayList(new int[] { 1,2,3 });
            Console.WriteLine(arrList2);
            Console.WriteLine();
            //arrList.AddValueByIndex(arrList2, 2);
            //arrList.AddValueToTheEnd(arrList2);
            arrList.AddValueToTheBegin(arrList2);
            Console.WriteLine();
            Console.WriteLine(arrList);

            LinkedList linkedlist = new LinkedList(new int[] { 4, 9, 7, 6, 2, 3, 8 });
            Console.WriteLine(linkedlist);
            linkedlist[2] = 10;
            Console.WriteLine(linkedlist);
        }
    }
}
 