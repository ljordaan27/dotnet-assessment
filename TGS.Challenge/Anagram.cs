using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            var alphaWord1 = IgnorePunctuation(word1.ToLowerInvariant());
            var alphaWord2 = IgnorePunctuation(word2.ToLowerInvariant());

            if(string.IsNullOrWhiteSpace(alphaWord1))
            {
                throw new System.ArgumentException("Word1 cannot be null. Please enter a valid word.");
            }

            if (string.IsNullOrWhiteSpace(alphaWord2))
            {
                throw new System.ArgumentException("Word2 cannot be null. Please enter a valid word.");
            }

            var arrAlphaWord1 = alphaWord1.ToCharArray();
            var arrAlphaWord2 = alphaWord2.ToCharArray();

            Array.Sort(arrAlphaWord1);
            Array.Sort(arrAlphaWord2);

            var sortedWord1 = new string(arrAlphaWord1);
            var sortedWord2 = new string(arrAlphaWord2);

            if(sortedWord1 == sortedWord2)
            {
                return true;
            }

            return false;
        }

        private string IgnorePunctuation(string word)
        {
            //could also be more explicit and use Regex.Replace(word, "[^a-zA-Z0-9]+", "") but \W_ excludes everything that non alphanumeric characters including underscores
            return Regex.Replace(word, @"[\W_]", string.Empty);
        }
    }
}
