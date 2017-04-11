using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronberg.LinkedList.Core.NonGeneric
{
    public class LinkedListItem
    {
        public string Item { get; }
        public LinkedListItem Next { get; internal set; }
        public LinkedListItem(string item, LinkedListItem next)
        {
            this.Item = item;
            this.Next = next;
        }
    }
}
