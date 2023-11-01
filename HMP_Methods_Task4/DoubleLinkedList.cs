using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HMP_Methods_Task4
{
    public class DoubleLinkedList<T>
    {
        int size;
        Node<T> head = null;
        Node<T> tail = null;

        public DoubleLinkedList(params T[] values)
        {
            foreach (var v in values)
                this.PushBack(v);
        }

        public void PushFront(T value)
        {
            Node<T> newHead = new Node<T>(value, head);
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

        public void PushBack(T value)
        {
            Node<T> newTail = new Node<T>(value, null);
            if (tail != null)
            {
                newTail.Previous = tail;
                tail.Next = newTail;
            }
            tail = newTail;

            if (head == null)
                head = tail;

            size++;
        }

        public List<int> FindValue(T value)
        {
            Node<T> currentElement = head;
            HashSet<int> result = new HashSet<int>();
            int index = 0;
            while (currentElement != null)
            {
                if (currentElement.Value.Equals(value))
                    result.Add(index + 1);
                index++;
                currentElement = currentElement.Next;
            }

            return result.ToList();
        }

        public void RemoveValue(T value)
        {
            //Node<T> currentElement = head;
            Node<T> fictionList = new Node<T>(value, head);
            Node<T> currentElement = fictionList;
            while (currentElement != null && currentElement.Next != null)
            {
                if (currentElement.Next.Value.Equals(value))
                {
                    var newNextNode = currentElement.Next.Next;
                    if (currentElement.Next == tail)
                        tail = currentElement;
                    currentElement.Next = newNextNode;
                    if (newNextNode != null)
                        newNextNode.Previous = currentElement;

                    size--;
                }
                currentElement = currentElement.Next;
            }
            
            head = fictionList.Next;
        }

    public T PopBack()
    {
        if (tail == null)
            throw new InvalidOperationException("List is empty");

        T value = tail.Value;
        tail = tail.Previous;
        size--;

        if (size == 0)
            head = null;

        return value;
    }

    public T PopFront()
    {
        if (head == null)
            throw new InvalidOperationException("List is empty");

        T value = head.Value;
        head = head.Next;
        size--;

        if (size == 0)
            tail = null;

        return value;
    }

    public void Clear()
    {
        while (this.Size() > 0)
            this.PopFront();
    }

    public T GetLast()
    {
        if (tail == null)
            throw new InvalidOperationException("List is empty");
        return tail.Value;
    }

    public T GetFirst()
    {
        if (head == null)
            throw new InvalidOperationException("List is empty");
        return head.Value;
    }

    public int Size() => size;

    public override string ToString()
    {
        Node<T> currentElement = head;
        string result = "";
        while (currentElement != null)
        {
            result += $"{currentElement.Value} ";
            currentElement = currentElement.Next;
        }
        result = result.Trim();

        return result;
    }
}
}
