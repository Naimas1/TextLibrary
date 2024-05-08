using System;
using TextLibrary;

class Program1
{
    static void Main(string[] args)
    {
        string text = "A man, a plan, a canal, Panama";

        bool isPalindrome = TextUtils.IsPalindrome(text);
        Console.WriteLine($"Is the text a palindrome? {isPalindrome}");

        int sentenceCount = TextUtils.CountSentences(text);
        Console.WriteLine($"Number of sentences in the text: {sentenceCount}");

        string reversedText = TextUtils.ReverseString(text);
        Console.WriteLine($"Reversed text: {reversedText}");
    }
}
