using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        int[] array = { 1, 0, 9, 7 };
        int count = 0;

        // Move non-zero elements to the beginning of the array
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                array[count++] = array[i];
            }
        }

        // Fill the rest of the array with zeros
        while (count < array.Length)
        {
            array[count++] = 0;
        }

        // Print the modified array
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
