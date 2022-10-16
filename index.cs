using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Nested Array
        int[][] numArray = { new int[] { 4, 2, 7, 1 },
                             new int[] { 20, 70, 40, 90 },
                             new int[] { 1, 2, 0 } };
        // Takes the largest number from the nested array and put it in its own array
        Console.WriteLine("[{0}]", string.Join(", ", (from values in numArray select values.Max())));
    }
}
