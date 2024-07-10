int[] array = { 1, 2, 4, 5, 3, 9 };
int largest_number = array[0];
int second_largest = -1;

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > largest_number)
    {
        second_largest = largest_number; // Update second largest with previous largest
        largest_number = array[i]; // Update largest number
    }
    else if (array[i] > second_largest && array[i] != largest_number)
    {
        second_largest = array[i]; // Update second largest if found a new candidate
    }
}

Console.WriteLine("The Largest number : " + largest_number);
Console.WriteLine("The Second largest number: " + second_largest);
