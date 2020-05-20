using System;
using System.Text;

// Implement a method to perform basic string compression using the counts of repeated characters.
// For example, the string aabcccccaaa would become a2b1c5a3. 
// If the “compressed” string would not become smaller than the original string, your method should return the original string. 
// Assume the string only has uppercase and lowercase letters (a-z).


namespace Exercises
{
    public class Compression
    {
        public string StringCompression(string str)
        {
            StringBuilder compressed = new StringBuilder();

            int countConsecutive = 0;
            const int reset = 0;

            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressed.Append(str[i]);
                    compressed.Append(countConsecutive);
                    countConsecutive = reset;
                }
            }
            if (compressed.Length < str.Length)
            {
                return compressed.ToString();
            }
            else
            {
                return str;
            }
        }
    }

    internal class Program
    {
        internal static void Main(string[] args)
        {
            Compression compressed = new Compression();
            string str = "aaabbbccccdddeee";
            string result = compressed.StringCompression(str);
            Console.WriteLine(result);
        }
    }
}