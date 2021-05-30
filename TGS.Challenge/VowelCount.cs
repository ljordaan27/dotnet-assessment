using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            var vowelCount = 0;

            if (!string.IsNullOrWhiteSpace(value) && value.Length > 0)
            {
                foreach (var vowel in vowels)
                {
                    vowelCount += value.ToLower().Split(vowel).Length - 1;
                }

                return vowelCount;
            }
            else
            {
                throw new ArgumentException("Input value cannot be null");
            }
        }
    }
}
