using System;
//Given two strings, write a method to decide if one is a permutation of the other?
namespace String2
{
    class Program
    {    
        /*Suppose that the set of possible characters in both strings is small. 
        The characters are stored using 8 bit and there can be 256 possible characters.
        1) Create count array of size 256 for one string.
        2) Iterate through every character of both strings and increment the count of character in the corresponding count arrays.
        3) Compare count arrays. If both count arrays are same, then return true.
        */
        static bool Permutation(string str1, string str2)
        {
            int[] letters = new int[256];
            for (int i = 0; i < str1.Length; i++)
            {
                letters[str1[i]]++;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                letters[str2[i]]--;
                if (letters[str1[i]] < 0)
                     return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string str1 = "dog abc";
            string str2 = "god acb";
            if (Permutation(str1, str2))
            {
                Console.WriteLine("One string is permutation of the other");
            }
            else
                Console.WriteLine("Both strings are different");
        }
    }
}
