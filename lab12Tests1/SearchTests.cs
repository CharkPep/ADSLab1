using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTests
{

    [TestClass()]
    public class EdgeCasesSearchTests
    {
        static List<int> arr;
        static data_struct.LinkedList<int> list;
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            arr = new List<int>();
            list = new data_struct.LinkedList<int>();
            for (int i = 0; i < 100000; i++)
            {
                arr.Add(i);
            }
            for (int i = 0; i < 100000; i++)
            {
                list.PushBack(i);
            }
            Debug.WriteLine("Successfuly filled array and list.");
            Debug.WriteLine($"Array size is: {arr.Count}, list size is {list.Size()}");
        }
        [TestMethod()]
        public void LinearSearchArrayTest()
        {
            int expected = 369;
            int actual = Search.LinearSearch(ref arr, 369);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LinearSearchLinkedListTest()
        {
            int expected = 369;
            int actual = Search.LinearSearch(ref list, 369);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LinearSearchArrayTest1()
        {
            int expected = -1;
            int actual = Search.LinearSearch(ref arr, 100000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LinearSearchLinkedListTest1()
        {
            int expected = -1;
            int actual = Search.LinearSearch(ref list, 100000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BarrierSearchArrayTest()
        {
            int expected = 369;
            int actual = Search.BarrierSearch(arr, 369);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BarrierSearchArrayTest1()
        {
            int expected = -1;
            int actual = Search.BarrierSearch(arr, 100000);
            Assert.AreEqual(expected, actual);
        }
        public void BarrierSearchLinkedListTest()
        {
            int expected = 369;
            int actual = Search.BarrierSearch(list, 369);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BarrierSearchLinkedListTest1()
        {
            int expected = -1;
            int actual = Search.BarrierSearch(list, 100000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BinarySearchArrayTest()
        {
            int expected = 369;
            int actual = Search.BinarySearch(ref arr, 0, list.Size(), 369);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinarySearchArrayTest1()
        {
            int expected = -1;
            int actual = Search.BinarySearch(ref arr, 0, list.Size(), 100000);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinarySearchLinkedListTest()
        {
            int expected = 369;
            int actual = Search.BinarySearch(ref list, 0, list.Size(), 369);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BinarySearchLinkedListTest1()
        {
            int expected = -1;
            int actual = Search.BinarySearch(ref list, 0, list.Size(), 100000);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinarySearchArrayModTest()
        {
            int expected = 369;
            int actual = Search.Binary_Search_Modify(ref arr, 0, list.Size(), 369);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinarySearchArrayModTest1()
        {
            int expected = -1;
            int actual = Search.Binary_Search_Modify(ref arr, 0, list.Size(), 100000);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinarySearchLinkedListModTest()
        {
            int expected = 369;
            int actual = Search.Binary_Search_Modify(ref list, 0, list.Size(), 369);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BinarySearchLinkedListModTest1()
        {
            int expected = -1;
            int actual = Search.Binary_Search_Modify(ref list, 0, list.Size(), 100000);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass()]
    public class SearchTestsRand
    {
        const int ARRAYSIZE = 100000000;
        static List<int> arr;
        static data_struct.LinkedList<int> list;
        static int expected = 0;
        static int to_search = 0;
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            var rand = new Random();
            arr = new List<int>();
            list = new data_struct.LinkedList<int>();
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                arr.Add(rand.Next(1000000));
            }
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                list.PushBack(arr[i]);
            }
            expected = rand.Next(ARRAYSIZE);
            to_search = arr[expected];
            Debug.WriteLine("Successfuly filled array and list.");
            Debug.WriteLine($"Array size is: {arr.Count}, list size is {list.Size()}");
        }
        [TestMethod()]
        public void LinearSearchArrayTest()
        {
            int actual = Search.LinearSearch(ref arr, to_search);
            if (arr[actual] == arr[expected])
            {
                return;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LinearSearchLinkedListTest()
        {
            int actual = Search.LinearSearch(ref list, to_search);
            if (arr[actual] == arr[expected])
            {
                return;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BarrierSearchArrayTest()
        {
            int actual = Search.BarrierSearch(arr, to_search);
            if (arr[actual] == arr[expected])
            {
                return;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BarrierSearchLinkedListTest()
        {
            int actual = Search.BarrierSearch(list, to_search);
            if (arr[actual] == arr[expected])
            {
                return;
            }
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class BinarySearchRandTest
    {
        const int ARRAYSIZE = 10000000;
        static List<int> arr;
        static data_struct.LinkedList<int> list;
        static int expected = 0;
        static int to_search = 0;
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            var rand = new Random();
            arr = new List<int>();
            list = new data_struct.LinkedList<int>();
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                arr.Add(rand.Next(1000000));
            }
            arr.Sort();
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                list.PushBack(arr[i]);
            }
            expected = rand.Next(ARRAYSIZE);
            to_search = arr[expected];
            
            Debug.WriteLine("Successfuly filled array and list.");
            Debug.WriteLine($"Array size is: {arr.Count}, list size is {list.Size()}");
        }
        [TestMethod()]
        public void BinarySearchArrayTest()
        {
            int actual = Search.BinarySearch(ref arr, 0, list.Size(), to_search);
            if (arr[actual] == arr[expected])
            {
                return;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BinarySearchLinkedListTest()
        {
            int actual = Search.BinarySearch(ref list, 0, list.Size(), to_search);
            Debug.WriteLine($"Expected: {arr[expected]}, got {arr[actual]}");
            if (arr[actual] == arr[expected])
            {
                return;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BinarySearchArrayModTest()
        {
            int actual = Search.Binary_Search_Modify(ref arr, 0, list.Size(), to_search);
            if (arr[actual] == arr[expected])
            {
                return;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BinarySearchLinkedListModTest()
        {
            int actual = Search.Binary_Search_Modify(ref list, 0, list.Size(), to_search);
            if (arr[actual] == arr[expected])
            {
                return;
            }
            Assert.AreEqual(expected, actual);
        }
    }
}