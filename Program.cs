using System;
using System.Linq;

namespace TextLibrary
{
    public static class TextUtils
    {
        public static bool IsPalindrome(string text)
        {
            string normalizedText = text.ToLower().Replace(" ", "");
            string reversedText = new string(normalizedText.Reverse().ToArray());
            return normalizedText == reversedText;
        }

        public static int CountSentences(string text)
        {
            char[] separators = { '.', '?', '!' };
            return text.Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
