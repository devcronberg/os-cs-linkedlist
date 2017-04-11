using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronberg.LinkedList.Core.Generic
{
    public class LinkedListItem<T>
    {
        public T Item { get; }
        public LinkedListItem<T> Next { get; set; }

        public LinkedListItem(T item, LinkedListItem<T> next)
        {
            this.Item = item;
            this.Next = next;
        }
    }
}
