using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMP_Methods_Task1
{
    internal class Node
    {
        public int Value { get; private set; }
        public Node Next { get; set; }

        public Node(int value, Node next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
