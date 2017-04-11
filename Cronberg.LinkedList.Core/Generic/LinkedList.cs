using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronberg.LinkedList.Core.Generic
{
    public class LinkedList<T>
    {
        private LinkedListItem<T> head;

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

        public T Remove()
        {
            if (this.head == null)
                return default(T);
            else
            {
                var node = head;
                LinkedListItem<T> prev = node;
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

        public void Insert(T item)
        {
            if (head == null)
                head = new LinkedListItem<T>(item, null);
            else
            {
                var node = head;
                while (node.Next != null)
                    node = node.Next;
                node.Next = new LinkedListItem<T>(item, null);
            }
        }

        public List<T> Items()
        {
            if (head == null)
                return new List<T>();
            else
            {
                var lst = new List<T>();
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
