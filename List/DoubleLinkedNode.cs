using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class DoubleLinkedNode
    {
        public int Values { get; set; }

        public DoubleLinkedNode Next { get; set; }
        public DoubleLinkedNode Previous { get; set; }

        public DoubleLinkedNode(int value)
        {
            Values = value;
            Next = null;
            Previous = null;
        }
    }
}
