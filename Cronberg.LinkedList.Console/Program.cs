using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cronberg.LinkedList.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Cronberg.LinkedList.Core.NonGeneric.LinkedList lst =
                    new Core.NonGeneric.LinkedList();
                lst.Insert("item 1");
                lst.Insert("item 2");

                WriteLine(lst.Count());
                WriteLine(string.Join(", ", lst.Items()));

                var item = lst.Remove();
                WriteLine(lst.Count());
                WriteLine(string.Join(", ", lst.Items()));

                item = lst.Remove();
                WriteLine(lst.Count());
                WriteLine(string.Join(", ", lst.Items()));
            }

            {
                Cronberg.LinkedList.Core.Generic.LinkedList<int> lst =
                    new Core.Generic.LinkedList<int>();
                lst.Insert(1);
                lst.Insert(2);

                WriteLine(lst.Count());
                WriteLine(string.Join(", ", lst.Items()));

                var item = lst.Remove();
                WriteLine(lst.Count());
                WriteLine(string.Join(", ", lst.Items()));

                item = lst.Remove();
                WriteLine(lst.Count());
                WriteLine(string.Join(", ", lst.Items()));
            }
        }
    }
}
