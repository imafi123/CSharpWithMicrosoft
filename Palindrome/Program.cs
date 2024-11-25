using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check if it's a palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"'{input}' is a palindrome.");
        }
        else
        {
            Console.WriteLine($"'{input}' is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false; // Treat null, empty, or whitespace strings as non-palindromes.

        str = str.ToLower(); // Convert to lowercase for case-insensitive comparison.

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            // Cool way to skip non-alphanumeric characters.
            while (left < right && !char.IsLetterOrDigit(str[left])) left++;
            while (left < right && !char.IsLetterOrDigit(str[right])) right--;

            if (str[left] != str[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
