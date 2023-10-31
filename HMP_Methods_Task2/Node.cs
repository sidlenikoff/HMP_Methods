using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMP_Methods_Task2
{
    internal class Node
    {
        public int Value { get; private set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(int value, Node next = null, Node previous = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}
