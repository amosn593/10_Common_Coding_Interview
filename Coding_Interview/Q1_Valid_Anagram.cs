using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview;

/// <summary>
/// Provides functionality to determine whether two strings are anagrams of each other.
/// </summary>
/// <remarks>This static class contains methods for comparing strings to check if they consist of the same
/// characters in any order. An anagram is defined as a word or phrase formed by rearranging the letters of another,
/// using all the original letters exactly once.</remarks>

public static class Q1_Valid_Anagram
{
    /// <summary>
    /// Determines whether two specified strings are anagrams of each other.
    /// </summary>
    /// <remarks>An anagram is defined as a word or phrase formed by rearranging the letters of another, using
    /// all the original letters exactly once. The comparison is case-sensitive and includes all characters, including
    /// whitespace and punctuation.</remarks>
    /// <param name="s">The first string to compare.</param>
    /// <param name="t">The second string to compare.</param>
    /// <returns>true if the strings are anagrams of each other; otherwise, false.</returns>
    public static bool IsAnagram(string s, string t)
    {
        if (s == null || t == null || s.Length != t.Length)
        {
            return false;
        }
        var charCount = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        foreach (var c in t)
        {
            if (!charCount.ContainsKey(c))
            {
                return false;
            }
            charCount[c]--;
            if (charCount[c] < 0)
            {
                return false;
            }
        }
        return true;
    }
}
