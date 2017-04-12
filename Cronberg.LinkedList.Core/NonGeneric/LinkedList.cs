using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronberg.LinkedList.Core.NonGeneric
{
    public class LinkedList
    {
        private LinkedListItem head;

        public int Count()
        {
            if (head == null)
                return 0;
            var node = head;
            var count = 1;
            while (node.Next != null)
            {
                node = node.Next;
                count++;
            }
            return count;
        }

        public string Remove()
        {
            if (this.head == null)
                throw new ApplicationException("Empty list");
            else
            {
                var node = head;
                LinkedListItem prev = node;
                while (node.Next != null)
                {
                    prev = node;
                    node = node.Next;
                }
                prev.Next = null;
                if (node == head)
                    head = null;
                return node.Item;
            }
        }

        public void Insert(string text)
        {
            if (head == null)
                head = new LinkedListItem(text, null);
            else
            {
                var node = head;
                while (node.Next != null)
                    node = node.Next;
                node.Next = new LinkedListItem(text, null);
            }
        }

        public List<string> Items()
        {
            if (head == null)
                return new List<string>();
            else
            {
                var lst = new List<string>();
                var node = head;
                do
                {
                    lst.Add(node.Item);
                    node = node.Next;
                }
                while (node != null);
                return lst;
            }
        }
    }
}
