using System;

namespace Anagrams
{
    public class AnagramCls
    {
        public string hola;

        public static bool CheckAnagrams(string word1, string word2)
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
                word1 = Reverse(word1);
                word2 = Reverse(word2);
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

        private static string Reverse(string input)
        {
            char[] temp = input.ToLowerInvariant().ToCharArray();
            Array.Sort(temp);
            return new string(temp);            
        }
    }
}
