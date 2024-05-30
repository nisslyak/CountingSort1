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
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arr)
    {
        List<int> countList = new List<int>();


        for (int i = 0; i < 100; i++)
        {
            int occurence = 0;

            occurence = arr.Count(n => n == i);

            countList.Add(occurence);
        }

        return countList;

    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Console.WriteLine("Here is the result");

        List<int> result = Result.countingSort(arr);

        Console.Write(string.Join<int>(" ", result));
    }
}
