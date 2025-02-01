using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string text)
        {
            text = text.ToLower();

            // შევადაროთ ტექსტი მის საპირისპირო ვერსიას
            string reversedText = new string(text.Reverse().ToArray());

            return text == reversedText;
        }
    }
}
