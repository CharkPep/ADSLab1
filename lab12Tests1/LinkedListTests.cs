using Microsoft.VisualStudio.TestTools.UnitTesting;
using data_struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace data_struct.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod]
        public void PushFrontTest()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.PushFront(1);
            list.PushFront(2);
            list.PushFront(3);
            list.PushFront(4);
            List<int> expected = new List<int>();
            expected.Add(4);
            expected.Add(3);
            expected.Add(2);
            expected.Add(1);
            List<int> actual = new List<int>();
            actual.Add(list[0]);
            actual.Add(list[1]);
            actual.Add(list[2]);
            actual.Add(list[3]);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PushBackTest()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.PushBack(1);
            list.PushBack(2);
            list.PushBack(3);
            list.PushBack(4);
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            List<int> actual = new List<int>();
            actual.Add(list[0]);
            actual.Add(list[1]);
            actual.Add(list[2]);
            actual.Add(list[3]);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PopBackTest()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.PushBack(1);
            list.PushBack(2);
            list.PushBack(3);
            list.PushBack(4);
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            list.PopBack();
            List<int> actual = new List<int>();
            actual.Add(list[0]);
            actual.Add(list[1]);
            actual.Add(list[2]);
            try
            {
                actual.Add(list[3]);
            }
            catch { }

            CollectionAssert.AreEqual(expected, actual);
        }
        public void PopFrontTest()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.PushBack(1);
            list.PushBack(2);
            list.PushBack(3);
            list.PushBack(4);
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            list.PopBack();
            List<int> actual = new List<int>();
            actual.Add(list[0]);
            actual.Add(list[1]);
            actual.Add(list[2]);
            try
            {
                actual.Add(list[3]);
            }
            catch { }

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EmptyTestPopBack()
        {
            var list = new LinkedList<int>();
            list.PushBack(1);
            list.PopBack();
            if (!list.Empty())
            {
                Assert.Fail();
            }
            Assert.IsTrue(true);
        }
        public void EmptyTestPopFront()
        {
            var list = new LinkedList<int>();
            list.PushBack(1);
            list.PopFront();
            if (!list.Empty())
            {
                Assert.Fail();
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void IndexOutOfBoundTest()
        {
            var list = new LinkedList<int>();
            list.PushBack(1);
            list.PushBack(1);
            list.PushBack(1);
            list.PushBack(1);
            bool flag = false;
            try
            {
                int a = list[5];
            }
            catch 
            {
                Debug.WriteLine("Exception caught. ");
                flag = true;
            }
            Assert.IsTrue(flag);
        }
    }
}