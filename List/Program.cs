using System;

namespace List
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(arrList);
            arrList.Revers();
            Console.WriteLine(arrList);
        }
    }
}
