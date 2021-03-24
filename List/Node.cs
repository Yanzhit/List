using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class Node
    {
        public int Values { get; set; }

        public Node Next { get; set; }

        public Node(int value)
        {
            Values = value;
            Next = null;
        }

    }
}
