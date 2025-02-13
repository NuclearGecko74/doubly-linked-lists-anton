using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListsAnton
{
    internal class Node
    {
        public object data;
        public Node prev;
        public Node next;

        public Node(object data)
        {
            this.data = data;
            next = null;
            prev = null;
        }

        public Node(object data, Node prev)
        {
            this.data = data;
            this.prev = prev;
            next = null;
        }
        
        public Node(object data, Node prev, Node next)
        {
            this.data = data;
            this.prev = prev;
            this.next = next;
        }
    }
}