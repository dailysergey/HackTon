using System;

namespace PermutationString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IsPermutation("Hello", "leHlo");
        }
        private static bool IsPermutation(string s1, string s2)
        {
            char[] x = s1.ToCharArray();
            char[] y = s2.ToCharArray();
            Array.Sort(x);
            Array.Sort(y);
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (x[i] == y[i])
                    count++;
            }
            if (count == s1.Length)
                return true;
            return false;
        }
    }
}
