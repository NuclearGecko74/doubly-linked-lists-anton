using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListsAnton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList(true);
            list.Append(5);
            list.Append(3);
            list.Prepend(69);

            list.DeleteFirst();

            list.PrintListBackwards();
        }
    }
}
