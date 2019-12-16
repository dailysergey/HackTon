using System;

namespace StringRotation
{
    class Program
    {
        static void Main()
        {
            if(new Program().IsSubstring("erbottlewat","waterbootle"))
                Console.WriteLine("Yes, s1 is rotation of s2");
            else
                Console.WriteLine("No");
        }
        /// <summary>
        /// Given two string s1 and s2, write code checks if s2 is a rotation of s1,
        /// using only one call of this method
        /// </summary>
        /// <param name="s1">Rotated srting</param>
        /// <param name="s2">Original string</param>
        /// <returns></returns>
        private bool IsSubstring(string s1,string s2)
        {
            return (s1 + s1).Contains(s2) && s1.Length == s2.Length;
        }
    }
}
