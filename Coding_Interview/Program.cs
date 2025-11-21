// See https://aka.ms/new-console-template for more information
using Coding_Interview;

Console.WriteLine("This is the Coding_Interview project.");

Console.WriteLine("Validating anagrams using Q1_Valid_Anagram.IsAnagram method:");
bool IsValidAnagram = Q1_Valid_Anagram.IsAnagram("danger", "garden");
Console.WriteLine($"IsValid Anagram {IsValidAnagram}");