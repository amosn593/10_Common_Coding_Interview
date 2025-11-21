using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview;

public class Q3_Find_Kth_Largest_Element
{
    public static int FindKthLargest(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k < 1 || k > nums.Length)
        {
            throw new ArgumentException("Invalid input");
        }
        Array.Sort(nums);
        //return nums[nums.Length - k];
        return nums[^k];
    }

    public static int FindKthLargest_Heap(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k < 1 || k > nums.Length)
        {
            throw new ArgumentException("Invalid input");
        }
        var minHeap = new SortedSet<(int value, int index)>();
        for (int i = 0; i < nums.Length; i++)
        {
            minHeap.Add((nums[i], i));
            if (minHeap.Count > k)
            {
                minHeap.Remove(minHeap.Min);
            }
        }
        return minHeap.Min.value;
    }

}
