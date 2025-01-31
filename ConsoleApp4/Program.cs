using System;

class Program
{
    static bool IsPalindrome(string text)
    {
        // გადააქციე ტექსტი პატარა ასოებად
        text = text.ToLower();

        // შევადაროთ ტექსტი მის საპირისპირო ვერსიას
        string reversedText = new string(text.Reverse().ToArray());

        return text == reversedText;
    }

    static void Main()
    {
        string input = "racecar";
        bool result = IsPalindrome(input);
        Console.WriteLine($"Is Palindrome: {result}");
    }
}