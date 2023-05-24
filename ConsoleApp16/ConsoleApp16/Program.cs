using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
    public class FindSubstring
    {
        public int subStringCount(string s1, string s2, ref List<int> indexes)
        {
            int count = 0;

            for (int i = 0; i <= s1.Length - s2.Length; i++)
            {
                if (s1.Substring(i, s2.Length) == s2)
                {
                    count++;
                    indexes.Add(i);
                }
            }

            return count;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter string 2");
            string string2 = Console.ReadLine();
            List<int> indexes = new List<int>();

            FindSubstring findSubstring = new FindSubstring();
            int count = findSubstring.subStringCount(string1, string2, ref indexes);

            Console.WriteLine($"Number of times occurred: {count}");
            Console.WriteLine($"Index Positions: ");

            if (indexes.Count == 0)
            {
                Console.Write("NULL");
            }

            else
            {
                for (int i = 0; i < indexes.Count; i++)
                {
                    Console.Write(indexes[i] + " ");
                }
            }
        }
    }
}
