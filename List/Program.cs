using System;

namespace List
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList(new int[] { 3, 5, 6, 8, 2, 1 });
            arrList.AddValueToTheBegin(new int[] { 3, 3, 3, 2 });
            Console.WriteLine();
        }
    }
}
 