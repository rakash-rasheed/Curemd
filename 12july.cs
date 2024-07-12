using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { -2, 10, 4 } ;
        int largest = 0;
        int small = int.MaxValue;
        int l = array.Length;
        int[] temp = new int[l];
        int diff ;
        int sum;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > largest)
            {
                largest = array[j];
            }
        }
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] < small)
            {
                small = array[k];
            }
        }
        
        
        for (int i = 0; i < l; i++)
        {
            if (array[i] > small || array[i] < largest)
            {
                diff = largest- array[i];
                sum = array[i] - small;
               
                
;                
            }

        }
        Console.WriteLine(sum-diff);

    }
}

