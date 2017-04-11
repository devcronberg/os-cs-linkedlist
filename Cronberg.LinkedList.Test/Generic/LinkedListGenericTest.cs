using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cronberg.LinkedList.Test.Generic
{
    [TestClass]
    public class LinkedListGenericTest
    {
        [TestMethod]
        public void GenericTestInsert()
        {
            Cronberg.LinkedList.Core.Generic.LinkedList<int> s = new Cronberg.LinkedList.Core.Generic.LinkedList<int>();
            Assert.IsTrue(s.Count() == 0);

            s.Insert(1);
            Assert.IsTrue(s.Count() == 1);

            s.Insert(2);
            Assert.IsTrue(s.Count() == 2);

            for (int i = 3; i < 100; i++)
                s.Insert(i);

            Assert.IsTrue(s.Count() == 99);



        }

        [TestMethod]
        public void GenericTestRemove()
        {
            Cronberg.LinkedList.Core.Generic.LinkedList<int> s = new Cronberg.LinkedList.Core.Generic.LinkedList<int>();
            s.Insert(1);
            Assert.IsTrue(s.Remove() == 1);

            s.Insert(1);
            s.Insert(2);
            s.Insert(3);
            Assert.IsTrue(s.Remove() == 3);
            Assert.IsTrue(s.Remove() == 2);
            Assert.IsTrue(s.Remove() == 1);

        }

        [TestMethod]
        public void GenericTestItems()
        {
            Cronberg.LinkedList.Core.Generic.LinkedList<int> s = new Cronberg.LinkedList.Core.Generic.LinkedList<int>();
            string res = string.Join(",", s.Items());
            Assert.IsTrue(res == "");

            s.Insert(1);
            res = string.Join(",", s.Items());
            Assert.IsTrue(res == "1");

            s.Insert(2);
            res = string.Join(",", s.Items());
            Assert.IsTrue(res == "1,2");

            s.Remove();
            res = string.Join(",", s.Items());
            Assert.IsTrue(res == "1");

            s.Remove();
            res = string.Join(",", s.Items());
            Assert.IsTrue(res == "");

        }
    }
}
