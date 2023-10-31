using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMP_Methods_Task1
{
    public class Stack
    {
        int size;
        Node head;

        public Stack()
        {
            size = 0;
            head = null;
        }

        public void Push(int val)
        {
            var newNode = new Node(val, head);
            head = newNode;
            size++;
        }

        public int Pop()
        {
            if (this.Size() <= 0)
                throw new InvalidOperationException("Stack is empty");
            int currentHeadValue = head.Value;
            head = head.Next;
            size--;
            return currentHeadValue;
        }

        public int Back()
        {
            if (this.Size() == 0)
                throw new InvalidOperationException("Stack is empty");
            return head.Value;
        }

        public int Size() => size;

        public void Clear()
        {
            while (this.Size() > 0)
                this.Pop();
        }
    }
}
