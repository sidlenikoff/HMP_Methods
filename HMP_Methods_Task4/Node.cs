using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMP_Methods_Task4
{
    internal class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T value, Node<T> next = null, Node<T> previous = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}
