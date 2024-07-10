using System;

class HelloWorld
{
    static void Main()
    {
        int[] Orginal_Array = { 2, 2, 3, 8, 5, 9, 3 };
        int[] Temp_Array = new int[Orginal_Array.Length]; // Initialize Temp_Array with the same length as Orginal_Array
        int j = 0;

        // Checking Orginal_Array to remove duplicates
        for (int i = 0; i < Orginal_Array.Length; i++)
       {
            bool isDuplicate = false;

            // Check if current element already exists in Temp_Array
            for (int k = 0; k < j; k++)//if the condition is false like in first iteration it 
            {
                if (Orginal_Array[i] == Temp_Array[k])
                {
                    isDuplicate = true;
                    break;
                }
            }

            // If not a duplicate, add to Temp_Array
            if (!isDuplicate)
            {
                Temp_Array[j] = Orginal_Array[i];// storing the value of orginal array index totemp array index
                j++;
            }
        }

        // Copy elements from Temp_Array back to Orginal_Array
        for (int i = 0; i < j; i++)
        {
            Orginal_Array[i] = Temp_Array[i];
        }

        // Print the unique elements in Orginal_Array
        for (int i = 0; i < j; i++)
        {
            Console.WriteLine(Orginal_Array[i]);
        }
    }
}


