# 10_Common_Coding_Interview

#### 1. Valid Anagram

#### 2. First and Last Position of Element in Sorted Array
1. Using Binary Search to find the first and last position of an element in a sorted array.
Time Complexity: O(log n)
Space Complexity: O(1)

2. Using Linear Search to find the first and last position of an element in a sorted array.
Time Complexity: O(n)
Space Complexity: O(1)

#### 3. Kth Largest Element in an Array
1. Repeatedly removing the maximum element from the array until the kth largest is found.
Time Complexity: O(n^2)
Space Complexity: O(1)

2. Sorting the array and accessing the kth largest element.
Time Complexity: O(n log n)
Space Complexity: O(1)

3. Using a Max-Heap to maintain the k largest elements.
Time Complexity: O(n log k)
Space Complexity: O(k)
