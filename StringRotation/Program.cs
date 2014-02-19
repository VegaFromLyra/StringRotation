using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assume you have a method isSubString which checks if one word is a substring
// of another. Given two strings, s1 and s2, write code to check if s2 is a 
// rotation of s1 using only one call to isSubString (Ex. "waterbottle" is a 
// rotation of "erbottlewat"
namespace StringRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "erbottlewat";
            string s2 = "waterbottle";

            Console.WriteLine("Is {0} a rotation of {1} : {2}", s1, s2, IsRotation(s1, s2));
        }

        static bool IsRotation(String s1, String s2)
        {
            if (String.IsNullOrEmpty(s1) || String.IsNullOrEmpty(s2))
            {
                return false;
            }

            if (s1.Length == s2.Length)
            {
                string combined = s1 + s1;

                return isSubstring(combined, s2);
            }

            return false;
        }

        static bool isSubstring(string s, string subStr)
        {
            return s.Contains(subStr);
        }
    }
}
