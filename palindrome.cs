// C# code​​​​​​‌​‌‌​​‌‌‌​‌‌​‌‌​​​​‌‌‌‌‌​ below
using System;
using System.Text;

// Write your answer here, and then test your code.

public class Answer {

    // Determine whether a string is a Palindrome
    public static bool IsPalindrome(string thestr) {
        // Your code goes here.
        StringBuilder normalizedStr = new StringBuilder();
        foreach (char c in thestr) {
            if (!Char.IsPunctuation(c) && !Char.IsWhiteSpace(c)) {
                normalizedStr.Append(Char.ToLower(c));
            }
        }

        // Reverse the normalized string
        StringBuilder reversedStr = new StringBuilder();
        for (int i = normalizedStr.Length - 1; i >= 0; i--) {
            reversedStr.Append(normalizedStr[i]);
        }

        // Debugging output
        Console.WriteLine($"Original: {normalizedStr}, Reversed: {reversedStr}");

        // Compare the normalized string and its reversed version
        return normalizedStr.ToString() == reversedStr.ToString();
    }
}
