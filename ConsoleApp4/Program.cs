﻿using ConsoleApp4;
using System;

class Program
{
    static async Task Main()
    {
        // პალინდრომის შემოწმება
        /*/
        string inputText = "A man, a plan, a canal, Panama!";
        bool isPalindrome = PalindromeChecker.IsPalindrome(inputText);
        Console.WriteLine($"Is '{inputText}' a palindrome? {isPalindrome}");

        // მონეტების მინიმალური რაოდენობა
        int amount = 98;
        int minCoins = CoinCalculator.MinCoins(amount);
        Console.WriteLine($"Minimum coins needed for {amount} tetri: {minCoins}");


        int[] array = { 1, 2, 3, 10 };
        int result = MassiveNotContain.NotContains(array);
        Console.WriteLine($"The smallest positive integer not in the array is: {result}");

        string sequence1 = "(()())";
        string sequence2 = "())()";

        Console.WriteLine($"Is '{sequence1}' properly balanced? {Sequence.IsProperly(sequence1)}");
        Console.WriteLine($"Is '{sequence2}' properly balanced? {Sequence.IsProperly(sequence2)}");

        int stairCount = 10;
        int stairresult = CountVariant.CountVariants(stairCount);
        Console.WriteLine($"Number of ways to climb {stairCount} stairs: {stairresult}");


        await CountryDataGenerator.GenerateCountryDataFiles();

        await SemaphoreExample.Run();/*/
        
        
        
        using (var context = new classroomDb())
        {
            var teachers = context.Pupils
                .Where(p => p.FirstName == "გიორგი")
                .SelectMany(p => p.TeacherPupils)
                .Select(tp => tp.Teacher)
                .ToList();

           
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher: {teacher.FirstName} {teacher.LastName}");
            }
        }

        Console.ReadKey();
    }
}