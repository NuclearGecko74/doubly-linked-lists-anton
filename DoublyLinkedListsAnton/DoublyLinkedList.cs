using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListsAnton
{
    internal class DoublyLinkedList
    {
        private Node head;
        private Node tail;

        private int length;
        private bool bIsCircular;

        public DoublyLinkedList(bool bIsCircular)
        {
            this.bIsCircular = bIsCircular;
            head = null;
            tail = null;
            length = 0;
        }

        public bool IsEmpty() { return  head == null; }

        public void Append(object data)
        {
            if (IsEmpty())
            {
                tail = head = new Node(data);
                if (bIsCircular) { tail.next = head; }
                length++;
                return;
            }

            //Node current = head;
            //while (current.next != null)
            //{
            //    current = current.next;
            //}
            //current.next = new Node(data, current);
            //tail = current.next;

            tail = tail.next = new Node(data, tail);
            if (bIsCircular) { tail.next = head; }
            length++;
        }

        public void Prepend(object data)
        {
            if (IsEmpty())
            {
                tail = head = new Node(data);
                if (bIsCircular) { tail.next = head; }
                length++;
                return;
            }
            head = head.prev = new Node(data, null, head);
            if (bIsCircular) { tail.next = head; }
            length++;
        }

        public Node DeleteLast()
        {
            if (!IsEmpty())
            {
                Node temp = tail;
                tail = tail.prev;
                tail.next = null;
                if (bIsCircular) { tail.next = head; }
                length--;
                return temp;
            }
            return null;
        }

        public Node DeleteFirst()
        {
            if (!IsEmpty())
            {
                Node temp = head;
                head = head.next;
                head.prev.next = null;
                head.prev = null;
                if (bIsCircular) { tail.next = head; }
                length--;
                return temp;
            }
            return null;
        }

        public void PrintList()
        {
            if (!IsEmpty())
            {
                Node current = head;
                //while (current != null)
                //{
                //    Console.WriteLine(current.data);
                //    current = current.next;
                //}

                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }

        public int GetLength() { return length; }
    }
}