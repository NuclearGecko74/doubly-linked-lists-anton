using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListsAnton
{
    internal class Program
    {
        // El menú fue hecho todo por chepete, ngl, las clases no, las hice desde cero
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList(false);
            list.Append(3);
            list.Append(4);
            list.Append(6);
            list.Append(7);

            list.Insert(0, 5);

            list.PrintList();
        }

    }
}
