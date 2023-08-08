////using System.CodeDom.Compiler;
////using System.Collections.Generic;
////using System.Collections;
////using System.ComponentModel;
////using System.Diagnostics.CodeAnalysis;
////using System.Globalization;
////using System.IO;
////using System.Linq;
////using System.Reflection;
////using System.Runtime.Serialization;
////using System.Text.RegularExpressions;
////using System.Text;
////using System;

////class Result
////{

////    /*
////     * Complete the 'plusMinus' function below.
////     *
////     * The function accepts INTEGER_ARRAY arr as parameter.
////     */

////    public static void plusMinus(List<int> arr)
////    {

////        int n = arr.Count;
////        int positiveCount = 0;
////        int negativeCount = 0;
////        int zeroCount = 0;

////        // Count occurrences of positive, negative, and zero values
////        foreach (int num in arr)
////        {
////            if (num > 0)
////            {
////                positiveCount++;
////            }
////            else if (num < 0)
////            {
////                negativeCount++;
////            }
////            else
////            {
////                zeroCount++;
////            }
////        }

////        // Calculate proportions
////        double totalNumbers = (double)n;
////        double positiveProportion = positiveCount / totalNumbers;
////        double negativeProportion = negativeCount / totalNumbers;
////        double zeroProportion = zeroCount / totalNumbers;

////        // Print results with 6 decimal places
////        Console.WriteLine($"{positiveProportion:F6}");
////        Console.WriteLine($"{negativeProportion:F6}");
////        Console.WriteLine($"{zeroProportion:F6}");
////    }
////}

////class Solution
////{
////    public static void Main(string[] args)
////    {
////        int n = Convert.ToInt32(Console.ReadLine().Trim());

////        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

////        Result.plusMinus(arr);
////    }
////}
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            // Print (n - i) spaces
            for (int j = 0; j < n - i; j++)


            {
                Console.Write(" ");
            }

            // Print i '#' characters
            for (int k = 0; k < i; k++)
            {
                Console.Write("#");
            }

            // Move to the next line
            Console.WriteLine();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}

////using System.CodeDom.Compiler;
////using System.Collections.Generic;
////using System.Collections;
////using System.ComponentModel;
////using System.Diagnostics.CodeAnalysis;
////using System.Globalization;
////using System.IO;
////using System.Linq;
////using System.Reflection;
////using System.Runtime.Serialization;
////using System.Text.RegularExpressions;
////using System.Text;
////using System;

////class Result
////{

////    /*
////     * Complete the 'miniMaxSum' function below.
////     *
////     * The function accepts INTEGER_ARRAY arr as parameter.
////     */

////    public static void miniMaxSum(List<int> arr)
////    {
////        // Calculate the total sum of all elements in the list using 64-bit long
////        long totalSum = arr.Sum(i => (long)i);

////        // Find the minimum and maximum elements in the list
////        int minElement = arr.Min();
////        int maxElement = arr.Max();

////        // Calculate the minimum sum by excluding the maximum element
////        long minSum = totalSum - maxElement;

////        // Calculate the maximum sum by excluding the minimum element
////        long maxSum = totalSum - minElement;

////        // Print the minimum and maximum sums
////        Console.WriteLine($"{minSum} {maxSum}");
////    }

////}

////class Solution
////{
////    public static void Main(string[] args)
////    {

////        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

////        Result.miniMaxSum(arr);
////    }
////}

