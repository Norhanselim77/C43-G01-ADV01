using System;
using System.Diagnostics.Metrics;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.Intrinsics.X86;




#region 1-Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. 
//The range should support basic operations such as checking if a value is within the range and determining the length of the range.
//Requirements:
//Create a generic class named Range<T> where T represents the type of values.
//Implement a constructor that takes the minimum and maximum values to define the range.
//Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
//Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
//Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.



//public class Range<T> where T : IComparable<T>
//{
//    private T _min;
//    private T _max;

//    public Range(T min, T max)
//    {
//        if (min.CompareTo(max) > 0)
//        {
//            throw new ArgumentException("Minimum value cannot be greater than maximum value.");
//        }

//        _min = min;
//        _max = max;
//    }

//    public bool IsInRange(T value)
//    {
//        return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
//    }

//    public T Length()
//    {
//        // Assuming T is a numeric type (e.g., int, double)
//        // This might need adjustments depending on the specific type of T
//        dynamic minDynamic = _min;
//        dynamic maxDynamic = _max;
//        return (dynamic)maxDynamic - (dynamic)minDynamic;
//    }
//}

#endregion
#region 2-You are given an ArrayList containing a sequence of elements.
//try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.


//public class ReverseArrayList
//{
//    public static void Reverse(ArrayList list)
//    {
//        if (list == null || list.Count <= 1)
//        {
//            return; // No need to reverse if empty or single element
//        }

//        int left = 0;
//        int right = list.Count - 1;

//        while (left < right)
//        {
//            // Swap elements at left and right indices
//            object temp = list[left];
//            list[left] = list[right];
//            list[right] = temp;

//            left++;
//            right--;
//        }
//    }
//}
#endregion
#region 3-You are given a list of integers.
//Your task is to find and return a new list containing only the even numbers from the given list.


//public class EvenNumberFinder
//{
//    public static List<int> FindEvenNumbers(List<int> numbers)
//    {
//        // Using LINQ for concise and efficient solution
//        return numbers.Where(n => n % 2 == 0).ToList();
//    }
//}
#endregion
#region 4-implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
//Requirements:
//Create a generic class named FixedSizeList<T>.
//Implement a constructor that takes the fixed capacity of the list as a 
//parameter.
//Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
//Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
//public class FixedSizeList<T>
//{
//    private readonly T[] _internalArray;
//    private int _count;

//    public FixedSizeList(int capacity)
//    {
//        if (capacity <= 0)
//        {
//            throw new ArgumentException("Capacity must be greater than zero.", nameof(capacity));
//        }

//        _internalArray = new T[capacity];
//        _count = 0;
//    }

//    public void Add(T item)
//    {
//        if (_count == _internalArray.Length)
//        {
//            throw new InvalidOperationException("List is full. Cannot add more elements.");
//        }

//        _internalArray[_count++] = item;
//    }

//    public T Get(int index)
//    {
//        if (index < 0 || index >= _count)
//        {
//            throw new IndexOutOfRangeException($"Index {index} is out of range.");
//        }

//        return _internalArray[index];
//    }
//}
#endregion
#region 5-Given a string, find the first non-repeated character in it 
//and return its index. If there is no such character, return 
//Hint: you can use dictionary
//public class Solution
//{
//    public int FirstUniqChar(string s)
//    {
//        // Create a dictionary to store character frequencies
//        var charCounts = new Dictionary<char, int>();

//        // Count the occurrences of each character
//        foreach (char c in s)
//        {
//            if (charCounts.ContainsKey(c))
//            {
//                charCounts[c]++;
//            }
//            else
//            {
//                charCounts[c] = 1;
//            }
//        }

//        // Find the index of the first non-repeating character
//        for (int i = 0; i < s.Length; i++)
//        {
//            if (charCounts[s[i]] == 1)
//            {
//                return i;
//            }
//        }

//        // If no non-repeating character is found, return -1
//        return -1;
//    }
//}


#endregion