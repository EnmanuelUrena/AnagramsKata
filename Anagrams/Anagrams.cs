using System;
using System.Collections.Generic;

namespace Anagrams
{
    public class Anagram
    {
        public static int cantWords = 0;
        public static Dictionary<string,string> findAnagrams(List<string> words)
        {
            Dictionary<string, string> anagram = new Dictionary<string, string>();
            foreach (var word in words)
            {
                string key = anagramHash(word);
                if (anagram.ContainsKey(key))
                {
                    string value = anagram[key];
                    cantWords++;
                    anagram[key] = string.Concat(value,',',word);
                }
                else
                {
                    anagram.Add(key,word);
                }
            }
            anagram = removeNotAnagram(anagram);
            return anagram;

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

        private static Dictionary<string, string> removeNotAnagram(Dictionary<string, string> anagram)
        {
            foreach (var item in anagram)
            {
                if (checkAnagrams(item.Key,item.Value))
                {
                    anagram.Remove(item.Key);
                }
            }
            return anagram;
        }

        private static string anagramHash(string input)
        {
            char[] temp = input.ToLowerInvariant().ToCharArray();
            Array.Sort(temp);
            return new string(temp);            
        }
    }
}
