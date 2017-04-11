using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Cronberg.LinkedList.Test.NonGeneric
{
    [TestClass]
    public class LinkedListNonGenericTest
    {
        [TestMethod]
        public void NonGenericTestInsert()
        {
            Cronberg.LinkedList.Core.NonGeneric.LinkedList s =
                new Cronberg.LinkedList.Core.NonGeneric.LinkedList();
            Assert.IsTrue(s.Count() == 0);

            s.Insert("text 1");
            Assert.IsTrue(s.Count() == 1);

            s.Insert("text 2");
            Assert.IsTrue(s.Count() == 2);

            for (int i = 3; i < 100; i++)
                s.Insert("text " + i);

            Assert.IsTrue(s.Count() == 99);

        }

        [TestMethod]
        public void NonGenericTestRemove()
        {
            Cronberg.LinkedList.Core.NonGeneric.LinkedList s = new Cronberg.LinkedList.Core.NonGeneric.LinkedList();
            s.Insert("text 1");
            Assert.IsTrue(s.Remove() == "text 1");

            s.Insert("text 1");
            s.Insert("text 2");
            s.Insert("text 3");
            Assert.IsTrue(s.Remove() == "text 3");
            Assert.IsTrue(s.Remove() == "text 2");
            Assert.IsTrue(s.Remove() == "text 1");
            Assert.IsTrue(s.Remove() == null);
            Assert.IsTrue(s.Remove() == null);

        }

        [TestMethod]
        public void NonGenericTestItems()
        {
            Cronberg.LinkedList.Core.NonGeneric.LinkedList s = new Cronberg.LinkedList.Core.NonGeneric.LinkedList();
            string res = string.Join(",", s.Items());
            Assert.IsTrue(res == "");

            s.Insert("text 1");
            res = string.Join(",", s.Items());
            Assert.IsTrue(res == "text 1");

            s.Insert("text 2");
            res = string.Join(",", s.Items());
            Assert.IsTrue(res == "text 1,text 2");

            s.Remove();
            res = string.Join(",", s.Items());
            Assert.IsTrue(res == "text 1");

            s.Remove();
            res = string.Join(",", s.Items());
            Assert.IsTrue(res == "");

        }
    }
}
