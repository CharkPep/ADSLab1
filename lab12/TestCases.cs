using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class TestCase
{
    //Випадок випадкової послідованості і випадкового значення
    public static bool TestCase1(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Wrong size for test 1");
            return false;
        }
        Console.WriteLine("TESTCASE_1");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Linear search 
        Console.WriteLine("TESTING LINEAR AND BARRIAR SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        for (int i = 0; i < n; i++)
        {
            int val = random.Next() % 100;
            list.Add(val);
            linkedList.PushBack(val);
        }
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        if (n <= 100)
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        else
        {
            Console.WriteLine("SKIPPED");
        }
        Console.WriteLine();
        int num = list[random.Next(list.Count - 1)];
        Console.WriteLine("LOOKING FOR " + num);
        Console.WriteLine("EXPECTED RESULT: ");
        int exp_res = list.IndexOf(num);
        Console.WriteLine(exp_res);
        Console.WriteLine("GOT USING LINEAR SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.LinearSearch(ref list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.LinearSearch(ref linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING BARRIER SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.BarrierSearch(list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.BarrierSearch(linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    //Випадок пустої послідовності
    public static bool TestCase2()
    {
        Console.WriteLine("TESTCASE_2");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Linear search 
        Console.WriteLine("TESTING LINEAR AND BARRIAR SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        int num = 0;
        Console.WriteLine("null");
        Console.WriteLine();
        Console.WriteLine("EXPECTED RESULT: ");
        int?exp_res = -1;
        Console.WriteLine("-1");
        Console.WriteLine("GOT USING LINEAR SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.LinearSearch(ref list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.LinearSearch(ref linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING BARRIER SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.BarrierSearch(list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.BarrierSearch(linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    //Випадок пошуку в випадковій последовності останього елемента
    public static bool TestCase3(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Wrong size for test 3");
            return false;
        }
        Console.WriteLine("TESTCASE_3");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Linear search 
        Console.WriteLine("TESTING LINEAR AND BARRIAR SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        for (int i = 0; i < n; i++)
        {
            int val = random.Next() % 100;
            list.Add(val);
            linkedList.PushBack(val);
        }
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        if (n <= 100)
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        else
        {
            Console.WriteLine("SKIPPED");
        }
        Console.WriteLine();
        int num = list[list.Count - 1];
        Console.WriteLine("LOOKING FOR " + num);
        Console.WriteLine("EXPECTED RESULT: ");
        int exp_res = list.IndexOf(num);
        Console.WriteLine(exp_res);
        Console.WriteLine("GOT USING LINEAR SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.LinearSearch(ref list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.LinearSearch(ref linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING BARRIER SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.BarrierSearch(list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.BarrierSearch(linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    //Випадок в випадковій последованості першого елемента
    public static bool TestCase4(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Wrong size for test 4");
            return false;
        }
        Console.WriteLine("TESTCASE_4");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Linear search 
        Console.WriteLine("TESTING LINEAR AND BARRIAR SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        for (int i = 0; i < n; i++)
        {
            int val = random.Next() % 100;
            list.Add(val);
            linkedList.PushBack(val);
        }
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        if (n <= 100)
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        else
        {
            Console.WriteLine("SKIPPED");
        }
        Console.WriteLine();
        int num = list[0];
        Console.WriteLine("LOOKING FOR " + num);
        Console.WriteLine("EXPECTED RESULT: ");
        int exp_res = list.IndexOf(num);
        Console.WriteLine(exp_res);
        Console.WriteLine("GOT USING LINEAR SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.LinearSearch(ref list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.LinearSearch(ref linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING BARRIER SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.BarrierSearch(list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.BarrierSearch(linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    //Випадок випадкової послідованості і випадкового значення
    public static bool TestCase5(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Wrong size for test 5");
            return false;
        }
        Console.WriteLine("TESTCASE_5");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Bin search
        Console.WriteLine("TESTING BINARY SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        for (int i = 0; i < n; i++)
        {
            int val = i;
            list.Add(val);
            linkedList.PushBack(val);
        }
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        if (n <= 100)
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        else
        {
            Console.WriteLine("SKIPPED");
        }
        Console.WriteLine();
        int num = list[random.Next(list.Count)];
        Console.WriteLine("LOOKING FOR " + num);
        Console.WriteLine("EXPECTED RESULT: ");
        int exp_res = list.IndexOf(num);
        Console.WriteLine(exp_res);
        Console.WriteLine("GOT USING BINARY SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.BinarySearch(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.BinarySearch(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING MODIFIED SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.Binary_Search_Modify(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.Binary_Search_Modify(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    //Випадок пустої послідовності
    public static bool TestCase6()
    {
        Console.WriteLine("TESTCASE_6");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Bin search
        Console.WriteLine("TESTING BINARY SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        Console.WriteLine("[null]");
        Console.WriteLine();
        int num = 0;
        Console.WriteLine("LOOKING FOR " + num);
        Console.WriteLine("EXPECTED RESULT: ");
        int exp_res = -1;
        Console.WriteLine(exp_res);
        Console.WriteLine("GOT USING BINARY SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.BinarySearch(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.BinarySearch(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING MODIFIED SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.Binary_Search_Modify(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.Binary_Search_Modify(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    //Випадок пошуку в випадковій последовності останього елемента
    public static bool TestCase7(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Wrong size for test 7");
            return false;
        }
        Console.WriteLine("TESTCASE_7");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Bin search
        Console.WriteLine("TESTING BINARY SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        for (int i = 0; i < n; i++)
        {
            int val = i;
            list.Add(val);
            linkedList.PushBack(val);
        }
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        if (n <= 100)
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        else
        {
            Console.WriteLine("SKIPPED");
        }
        Console.WriteLine();
        int num = list[0];
        Console.WriteLine("LOOKING FOR " + num);
        Console.WriteLine("EXPECTED RESULT: ");
        int exp_res = list.IndexOf(num);
        Console.WriteLine(exp_res);
        Console.WriteLine("GOT USING BINARY SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.BinarySearch(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.BinarySearch(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING MODIFIED SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.Binary_Search_Modify(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.Binary_Search_Modify(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    //Випадок в випадковій последованості першого елемента
    public static bool TestCase8(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Wrong size for test 8");
            return false;
        }
        Console.WriteLine("TESTCASE_8");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Bin search
        Console.WriteLine("TESTING BINARY SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        for (int i = 0; i < n; i++)
        {
            int val = i;
            list.Add(val);
            linkedList.PushBack(val);
        }
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        if (n <= 100)
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        else
        {
            Console.WriteLine("SKIPPED");
        }
        Console.WriteLine();
        int num = list[list.Count - 1];
        Console.WriteLine("LOOKING FOR " + num);
        Console.WriteLine("EXPECTED RESULT: ");
        int exp_res = list.IndexOf(num);
        Console.WriteLine(exp_res);
        Console.WriteLine("GOT USING BINARY SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.BinarySearch(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.BinarySearch(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING MODIFIED SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.Binary_Search_Modify(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.Binary_Search_Modify(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    public static bool TestCase9(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Wrong size for test 9");
            return false;
        }
        Console.WriteLine("TESTCASE_9");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Linear search 
        Console.WriteLine("TESTING LINEAR AND BARRIAR SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        for (int i = 0; i < n; i++)
        {
            int val = random.Next() % 100;
            list.Add(val);
            linkedList.PushBack(val);
        }
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        if (n <= 100)
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        else
        {
            Console.WriteLine("SKIPPED");
        }
        Console.WriteLine();
        int num = -1;
        Console.WriteLine("LOOKING FOR " + num);
        Console.WriteLine("EXPECTED RESULT: ");
        int exp_res = -1;
        Console.WriteLine(exp_res);
        Console.WriteLine("GOT USING LINEAR SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.LinearSearch(ref list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.LinearSearch(ref linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING BARRIER SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.BarrierSearch(list, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.BarrierSearch(linkedList, num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    public static bool TestCase10(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Wrong size for test 10");
            return false;
        }
        Console.WriteLine("TESTCASE_10");
        var interval1 = new Stopwatch();
        var interval2 = new Stopwatch();
        bool res = true;
        Random random = new Random();
        //Testing Bin search
        Console.WriteLine("TESTING BINARY SEARCH ON ARRAY AND LINKED LIST");
        List<int> list = new List<int>();
        data_struct.LinkedList<int> linkedList = new data_struct.LinkedList<int>();
        //Random values
        for (int i = 0; i < n; i++)
        {
            int val = i;
            list.Add(val);
            linkedList.PushBack(val);
        }
        Console.WriteLine("ARRAY(Array is the same as linked list): ");
        if (n <= 100)
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        else
        {
            Console.WriteLine("SKIPPED");
        }
        Console.WriteLine();
        int num = -1;
        Console.WriteLine("LOOKING FOR " + num);
        Console.WriteLine("EXPECTED RESULT: ");
        int exp_res = -1;
        Console.WriteLine(exp_res);
        Console.WriteLine("GOT USING BINARY SEARCH: ");
        interval1.Reset();
        interval1.Start();
        int res1 = Search.BinarySearch(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        int res2 = Search.BinarySearch(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        Console.WriteLine("GOT USING MODIFIED SEARCH: ");
        interval1.Reset();
        interval1.Start();
        res1 = Search.Binary_Search_Modify(ref list, 0, list.Count, num);
        interval1.Stop();
        interval2.Reset();
        interval2.Start();
        res2 = Search.Binary_Search_Modify(ref linkedList, 0, linkedList.Size(), num);
        interval2.Stop();
        Console.WriteLine(res1 + " " + res2);
        Console.WriteLine($"Time with array: {interval1.Elapsed}");
        Console.WriteLine($"Time with linked list: {interval2.Elapsed}");
        if (res1 != exp_res || res2 != exp_res)
        {
            res = false;
        }
        return res;
    }
    public static void Run()
    {
        const int LINEARSEARCHSIZE = 100000000;
        const int BINARYSEARCHSIZE = 10000000;
        Console.WriteLine("-------------------------\n   LINEAR AND BARRIER SEARCH TESTS\n -------------------------");
        Console.WriteLine($"Test passed: {TestCase.TestCase1(LINEARSEARCHSIZE) == true}");
        Console.WriteLine($"Test passed: {TestCase.TestCase2() == true}");
        Console.WriteLine($"Test passed: {TestCase.TestCase3(LINEARSEARCHSIZE) == true}");
        Console.WriteLine($"Test passed: {TestCase.TestCase4(LINEARSEARCHSIZE) == true}");
        Console.WriteLine("-------------------------\n   BINARY SEARCH TESTS\n -------------------------");
        Console.WriteLine($"Test passed: {TestCase.TestCase5(BINARYSEARCHSIZE) == true}");
        Console.WriteLine($"Test passed: {TestCase.TestCase6() == true}");
        Console.WriteLine($"Test passed: {TestCase.TestCase7(BINARYSEARCHSIZE) == true}");
        Console.WriteLine($"Test passed: {TestCase.TestCase8(BINARYSEARCHSIZE) == true}");
        Console.WriteLine("-------------------------\n   LINEAR AND BARRIER SEARCH TEST\n -------------------------");
        Console.WriteLine($"Test passed: {TestCase.TestCase9(BINARYSEARCHSIZE) == true}");
        Console.WriteLine("-------------------------\n   BINARY SEARCH TESTS\n -------------------------");
        Console.WriteLine($"Test passed: {TestCase.TestCase10(BINARYSEARCHSIZE) == true}");
    }
}
