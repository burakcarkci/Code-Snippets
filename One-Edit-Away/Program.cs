using System;

// Given two strings, return true if they are one edit away from each other,else return false.
// An edit is insert/replace/delete a character.
// Ex. {"abc","ab"}->true, {"abc","adc"}->true, {"abc","cab"}->false

namespace Exercises
{
    public class OneAway
    {
        public bool OneEditAway(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                return OneEditReplace(str1, str2);
            }
            else if (str1.Length + 1 == str2.Length)
            {
                return OneEditInsert(str1, str2);
            }
            else if (str1.Length - 1 == str2.Length)
            {
                return OneEditInsert(str1, str2);
            }
            return true;
        }

        private bool OneEditReplace(string str1, string str2)
        {
            bool foundDifference = false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    if (foundDifference)
                    {
                        return false;
                    }
                    foundDifference = true;
                }
            }
            return true;
        }

        private bool OneEditInsert(string str1, string str2)
        {
            int index1 = 0;
            int index2 = 0;
            while (index1 < str1.Length && index2 < str2.Length)
            {
                if (str1[index1] != str2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }
    }

    internal class Program
    {
        internal static void Main(string[] args)
        {
            OneAway editAway = new OneAway();
            bool result = editAway.OneEditAway("abc", "ab");
            Console.WriteLine(result);
        }
    }
}