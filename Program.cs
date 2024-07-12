using System;
using System.Linq;

class NonRepeatingChar
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a String:");
        string word = Console.ReadLine();
        char firstNonRepeatingChar = '\0';
        int[] charCount = new int[256]; // Assuming ASCII characters

        // Count the occurrences of each character
        foreach (char ch in word)
        {
            charCount[ch]++;
        }

        // Find the first non-repeating character
        foreach (char ch in word)
        {
            if (charCount[ch] == 1)
            {
                firstNonRepeatingChar = ch;
                break;
            }
        }

        if (firstNonRepeatingChar != '\0')
        {
            Console.WriteLine("The first character which is not repeating is: " + firstNonRepeatingChar);
        }
        else
        {
            Console.WriteLine("There is no non-repeating character in the input.");
        }
    }
    static void mergeArrays(int[] arr1, int[] arr2, int n1, int n2, int[] arr3)
    {
        int i = 0;
        int j = 0;
        int k = 0;

        // traverse the arr1 and insert its element in arr3
        while (i < n1)
        {
            arr3[k++] = arr1[i++];
        }

        // now traverse arr2 and insert in arr3
        while (j < n2)
        {
            arr3[k++] = arr2[j++];
        }

        // sort the whole array arr3
        Array.Sort(arr3);
    }

}
