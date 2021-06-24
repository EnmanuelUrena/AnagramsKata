using System;
using System.Collections.Generic;
using Anagrams;

namespace AnagramConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("pedro");
            list.Add("miro");
            list.Add("drope");
            list.Add("cora");
            list.Add("ropde");
            list.Add("porra");
            list.Add("romi");
            var result = Anagram.findAnagrams(list);
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
