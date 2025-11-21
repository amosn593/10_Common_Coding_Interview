// See https://aka.ms/new-console-template for more information
using Coding_Interview;

Console.WriteLine("This is the Coding_Interview project.");

// Testing Q1_Valid_Anagram.IsAnagram method
Console.WriteLine("Validating anagrams using Q1_Valid_Anagram.IsAnagram method:");
bool IsValidAnagram = Q1_Valid_Anagram.IsAnagram("danger", "garden");
Console.WriteLine($"IsValid Anagram {IsValidAnagram}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Testing Q2_First_Last_Index_Element_SortedArray.FindFirstAndLastIndex method
Console.WriteLine("Finding first and last index of target in sorted array using Q2_First_Last_Index_Element_SortedArray.FindFirstAndLastIndex method:");
var (firstIndex, lastIndex) = Q2_First_Last_Index_Element_SortedArray.FindFirstAndLastIndex(new int[] { 5, 7, 7, 8, 8, 10 }, 5);
Console.WriteLine("First Index: " + firstIndex + ", Last Index: " + lastIndex);

// Testing Q3_Find_Kth_Largest_Element.FindKthLargest method
Console.WriteLine("Finding Kth largest element using Q3_Find_Kth_Largest_Element.FindKthLargest method:");
int kthLargest = Q3_Find_Kth_Largest_Element.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2);
Console.WriteLine("Kth Largest Element: " + kthLargest);
