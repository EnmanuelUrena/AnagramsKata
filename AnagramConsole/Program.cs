using System;
using System.Collections.Generic;
using System.IO;
using Anagrams;

namespace AnagramConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = readFile("wordlist.txt");
            var result = Anagram.findAnagrams(list);
            System.Console.WriteLine(Anagram.cantWords);

        }
        static List<string> readFile(string path)
        {
            StreamReader stream = new StreamReader(path);
            string linesr1;
            var DataList = new List<string>();
            while ((linesr1 = stream.ReadLine()) != null)
            {
               DataList.Add(linesr1);
            }
            return DataList;
        }
    }
}
