using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class FirstOccurrenceOfString
    {
        //FirstOccurrenceOfString firstOccurrenceOfString = new();
        //Console.WriteLine(firstOccurrenceOfString.StrStr("Hello", "World"));

        public int StrStr(string haystack, string needle)
        {
            
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack.Substring(i, needle.Length).Equals(needle))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
