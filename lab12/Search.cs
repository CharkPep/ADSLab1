using System.Buffers.Text;
using System;
using System.Drawing;
using System.Numerics;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using data_struct;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Diagnostics;

public class Search
{
    private static double _F = 1.6180339887498948482;
    //Slower version of Binary Search
/*    public static int BinarySearch<T>(ref List<T> arr, T key) where T : IComparable
    {
        int index = -1;
        int left = 0;
        int right = arr.Count - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            T item = arr[mid];
            int result = key.CompareTo(item);
            if (result == 0)
            {
                index = mid;
                break;
            }
            if (result < 0)
                right = mid - 1;
            else
                left = mid + 1;
        }
        return index;
    }
    public static int BinarySearch<T>(ref data_struct.LinkedList<T> arr, T key) where T : IComparable
    {
        int index = -1;
        int left = 0;
        int right = arr.Size() - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            T item = arr[mid];
            int result = key.CompareTo(item);
            if (result == 0)
            {
                index = mid;
                break;
            }
            if (result < 0)
                right = mid - 1;
            else
                left = mid + 1;
        }
        return index;
    }*/
    public static int LinearSearch<T>(ref List<T> arr, T key) where T : IComparable
    {
        int len = arr.Count;
        int index = -1;
        for (int i = 0; i < len; i++)
        {
            T item = arr[i];
            int result = key.CompareTo(item);
            if (result == 0)
            {
                index = i;
                break;
            }
        }
        return index;
    }
    public static int LinearSearch<T>(ref data_struct.LinkedList<T> arr, T key) where T : IComparable
    {
        int len = arr.Size();
        int index = -1;
        foreach (Tuple<T,int> i in arr)
        {
            T item = i.Item1;
            int result = key.CompareTo(item);
            if (result == 0)
            {
                index = i.Item2;
                break;
            }
        }
        return index;
    }
    public static int BarrierSearch<T>(List<T> arr, T key) where T : IComparable
    {
        arr.Add(key);
        int len = arr.Count;
        int i = 0;
        while (key.CompareTo(arr[i]) != 0)
        {
            i++;
        }
        if (i == arr.Count - 1)
        {
            arr.RemoveAt(arr.Count - 1);
            return -1;
        }
        arr.RemoveAt(arr.Count - 1);
        return i;
    }
    public static int BarrierSearch<T>(data_struct.LinkedList<T> arr, T key) where T : IComparable
    {
        arr.PushBack(key);
        int len = arr.Size();
        //var itr = LinkedList<T>.Enumerator;
        var head = arr.First();
        int i = 0;
        var interval1 = new Stopwatch();
        interval1.Reset();
        interval1.Start();
        while (key.CompareTo(head.Data) != 0)
        {
            head = head.Next;
            i++;
        }
        interval1.Stop();
        Debug.WriteLine(interval1.Elapsed);
        if (head.Next == null)
        {
            arr.PopBack();
            return -1;
        }
        arr.PopBack();
        return i;
    }
    public static int BinarySearch<T>(ref List<T> arr, int l, int r, T key) where T : IComparable
    {

        if (r >= l && arr.Count != 0)
        {
            int mid = l + (r - l) / 2;
            if (mid >= arr.Count)
                return -1;
            if (key.CompareTo(arr[mid]) == 0)
                return mid;

            if (key.CompareTo(arr[mid]) < 0)
                return BinarySearch(ref arr, l, mid - 1, key);

            return BinarySearch(ref arr, mid + 1, r, key);
        }

        return -1;
    }
    public static int BinarySearch<T>(ref T[]arr, int l, int r, T key) where T : IComparable
    {

        if (r >= l && arr.Length != 0)
        {
            int mid = l + (r - l) / 2;
            if (mid >= arr.Length)
                return -1;
            if (key.CompareTo(arr[mid]) == 0)
                return mid;

            if (key.CompareTo(arr[mid]) < 0)
                return BinarySearch(ref arr, l, mid - 1, key);

            return BinarySearch(ref arr, mid + 1, r, key);
        }

        return -1;
    }
    public static int BinarySearch<T>(ref data_struct.LinkedList<T> arr, int l, int r, T key) where T : IComparable
    {

        if (r >= l && arr.Size() != 0)
        {
            int mid = l + (r - l) / 2;
            if (mid >= arr.Size())
                return -1;
            if (key.CompareTo(arr[mid]) == 0)
                return mid;

            if (key.CompareTo(arr[mid]) < 0)
                return BinarySearch(ref arr, l, mid - 1, key);

            return BinarySearch(ref arr, mid + 1, r, key);
        }

        return -1;
    }
    public static int Binary_Search_Modify<T>(ref List<T> arr, int l, int r, T key) where T : IComparable
    {
        if (r >= l && arr.Count != 0)
        {
            int mid = Convert.ToInt32(l * _F);
            if (mid >= arr.Count)
                return -1;
            if (key.CompareTo(arr[mid]) == 0)
                return mid;

            if (key.CompareTo(arr[mid]) < 0)
                return BinarySearch(ref arr, l, mid - 1, key);

            return BinarySearch(ref arr, mid + 1, r, key);
        }

        return -1;
    }
    public static int Binary_Search_Modify<T>(ref data_struct.LinkedList<T> arr, int l, int r, T key) where T : IComparable
    {
        if (r >= l && arr.Size() != 0)
        {
            int mid = Convert.ToInt32(l * _F);
            if (mid >= arr.Size())
                return -1;
            if (key.CompareTo(arr[mid]) == 0)
                return mid;

            if (key.CompareTo(arr[mid]) < 0)
                return BinarySearch(ref arr, l, mid - 1, key);

            return BinarySearch(ref arr, mid + 1, r, key);
        }

        return -1;
    }
}