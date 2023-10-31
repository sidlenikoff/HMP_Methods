using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMP_Methods_Task2
{
    public class Queue
    {
        int size;
        Node head = null;
        Node tail = null;

        public void Push(int value)
        {
            Node newHead = new Node(value, head);
            if (head != null)
            {
                newHead.Previous = head.Previous;
                head.Previous = newHead;
            }

            head = newHead;

            if (tail == null)
                tail = head;

            size++;
        }

        public int Pop()
        {
            if (this.Size() <= 0)
                throw new InvalidOperationException("Queue is empty");

            int tailValue = tail.Value;
            tail = tail.Previous;
            if(tail != null)
                tail.Next = null;

            if (tail == null)
                head = null;

            size--;

            return tailValue;
        }

        public int Front()
        {
            if (this.Size() <= 0)
                throw new InvalidOperationException("Queue is empty");
            return tail.Value;
        }

        public int Size() => size;

        public void Clear()
        {
            while (this.Size() > 0)
                this.Pop();
        }
    }
}
