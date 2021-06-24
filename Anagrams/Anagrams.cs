using System;
using System.Collections.Generic;

namespace Anagrams
{
    public class AnagramCls
    {

        public static void findAnagrams(List<string> words)
        {
            Dictionary<string, string> anagram = new Dictionary<string, string>();
            foreach (var word in words)
            {
                string key = anagramHash(word);
                if (anagram.ContainsKey(key))
                {
                    anagram[key] = string.Join(',',word);
                }
                else
                {
                    anagram.Add(key,null);
                }
            }

        }

        private static bool checkAnagrams(string word1, string word2)
        {
            if (word1 == null || word2 == null)
            {
                throw new ArgumentNullException();
            }

            if (word1.Length != word2.Length)
            {
                return false;
            }

            else
            {
                word1 = anagramHash(word1);
                word2 = anagramHash(word2);
                if (word1 == word2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private static string anagramHash(string input)
        {
            char[] temp = input.ToLowerInvariant().ToCharArray();
            Array.Sort(temp);
            return new string(temp);            
        }
    }
}
