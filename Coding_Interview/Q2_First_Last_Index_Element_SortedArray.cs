using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview;

public static class Q2_First_Last_Index_Element_SortedArray
{
    /// <summary>
    /// Finds the first and last index of the specified target value within a sorted array.
    /// </summary>
    /// <remarks>The input array must be sorted in ascending order for correct results. If the target value
    /// appears multiple times, the method returns the indices of its first and last occurrence. If the target does not
    /// exist in the array, the method returns (-1, -1).</remarks>
    /// <param name="nums">A sorted array of integers in which to search for the target value.</param>
    /// <param name="target">The value to locate within the array.</param>
    /// <returns>A tuple containing the first and last index of the target value in the array. If the target is not found, both
    /// indices are -1.</returns>
    public static (int firstIndex, int lastIndex) FindFirstAndLastIndex(int[] nums, int target)
    {
        int firstIndex = -1;
        int lastIndex = -1;
        // Edge case: empty array
        if (nums == null || nums.Length == 0 || nums[0] > target || nums[^1] < target)
        {
            return (firstIndex, lastIndex);
        }

        // Find first index
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                firstIndex = mid;
                right = mid - 1; // Continue searching in the left half
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        // Find last index
        left = 0;
        right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                lastIndex = mid;
                left = mid + 1; // Continue searching in the right half
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return (firstIndex, lastIndex);
    }
}
