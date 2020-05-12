using System;

// Check if given strings are isomorphic
// "egg" and "add"
//  122       122       true
// "kkki"  and "kkai"
//  111         112     false
// "paper" and "title"
//  12134       12134   true

namespace Exercises
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s1, string s2)
        {
            if (s1 == null || s2 == null || s1.Length != s2.Length)
            {
                return false;
            }

            //Total size of ascii table 256
            int[] recordS1 = new int[256];
            int[] recordS2 = new int[256];
            var label = 1;

            for (int i = 0; i < s1.Length; i++)
            {
                //saves ascii number of a char to int variable
                int char1 = s1[i];
                int char2 = s2[i];

                //if label of char1 isn't equal to char2 label return false
                if (recordS1[char1] != recordS2[char2])
                {
                    return false;
                }

                //if label isn't set for current index set current label and increse label by1
                if (recordS1[char1] == 0)
                {
                    recordS1[char1] = label;
                    recordS2[char2] = label;
                    label++;
                }
            }
            return true;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            IsomorphicStrings isomorphicStrings = new IsomorphicStrings();
            bool result1 = isomorphicStrings.IsIsomorphic("kkki", "kkai");
            bool result2 = isomorphicStrings.IsIsomorphic("title", "paper");
            bool result3 = isomorphicStrings.IsIsomorphic("nap", "faso");

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}