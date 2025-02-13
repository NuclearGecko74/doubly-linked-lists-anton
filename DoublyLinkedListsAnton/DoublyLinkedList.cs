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

        private bool bIsCircular;

        public DoublyLinkedList(bool bIsCircular)
        {
            this.bIsCircular = bIsCircular;
            head = null;
            tail = null;
        }

        public bool IsEmpty() { return  head == null; }

        public void Append(object data)
        {
            if (IsEmpty())
            {
                tail = head = new Node(data);
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
        }

        public void Prepend(object data)
        {
            if (IsEmpty())
            {
                tail = head = new Node(data);
                return;
            }
            head = head.prev = new Node(data, null, head);
        }

        public void PrintList()
        {
            if (!IsEmpty())
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }
    }
}