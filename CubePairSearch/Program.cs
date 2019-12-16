using System;
using System.Collections.Generic;

namespace CubePairSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintDict(GetCubePair());
        }
        /// <summary>
        /// algorithm for cube printing combinations of a and b variables.
        /// </summary>
        /// <returns></returns>
        private static Dictionary<int, List<Tuple<int, int>>> GetCubePair()
        {
            Dictionary<int, List<Tuple<int, int>>> result = new Dictionary<int, List<Tuple<int, int>>>();
            for (int a = 1; a < int.MaxValue; a++)
            {
                for (int b = 1; b < int.MaxValue; b++)
                {
                    int cube = (int)(Math.Pow(a, 3) + Math.Pow(b, 3));
                    if (cube < 0)
                        break;
                    if (result.TryGetValue(cube, out List<Tuple<int, int>> pairs) && cube > 0)
                    {
                        pairs.Add(new Tuple<int, int>(a, b));
                    }
                    else
                    {
                        List<Tuple<int, int>> t = new List<Tuple<int, int>>();
                        t.Add(new Tuple<int, int>(a, b));
                        result.TryAdd(cube, t);
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Print result of GetCubePair() method
        /// </summary>
        /// <param name="result"></param>
        private static void PrintDict (Dictionary<int, List<Tuple<int, int>>> result)
        { 
            foreach (var keyValue in result)
            {
                Console.WriteLine($"Printing pair for cube = {keyValue.Key}:");
                Console.WriteLine("========");
                foreach (var pair in keyValue.Value)
                {
                    Console.WriteLine($"[{pair.Item1},{pair.Item2}];");
                }
                Console.WriteLine("========");
            }
        }
    }
}
