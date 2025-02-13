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
            }
            else
            {
                tail = tail.next = new Node(data, tail);
            }

            //Node current = head;
            //while (current.next != null)
            //{
            //    current = current.next;
            //}
            //current.next = new Node(data, current);
            //tail = current.next;

            
            CheckForCircularity();
            length++;
        }

        public void Prepend(object data)
        {
            if (IsEmpty())
            {
                tail = head = new Node(data);
            }
            else
            {
                head = head.prev = new Node(data, null, head);
            }
            
            CheckForCircularity();
            length++;
        }

        public Node DeleteLast()
        {
            if (IsEmpty()) return null;

            Node temp = tail;

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }

            CheckForCircularity();
            length--;
            return temp;
        }

        public Node DeleteFirst()
        {
            if (IsEmpty()) return null;

            Node temp = head;
            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }

            CheckForCircularity();
            length--;
            return temp;
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

        public void PrintListBackwards()
        {
            Node current = tail;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(current.data);
                current = current.prev;
            }
        }

        public int GetLength() { return length; }

        private void CheckForCircularity()
        {
            if (bIsCircular && !IsEmpty()) 
            { 
                tail.next = head; 
                head.prev = tail; 
            }
        }
    }
}