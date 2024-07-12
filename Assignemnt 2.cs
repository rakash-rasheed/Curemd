using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choice option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("You have selected option 1");
                    ArmStrong();
                    break;
                case 2:
                    Console.WriteLine("You have selected option 2");
                    Console.WriteLine("Enter number to find Fibonacci Sequence ");
                    int Length = Convert.ToInt32(Console.ReadLine());
                    Fibonacci_sequence(Length);
                    break;
                case 3:
                    Console.WriteLine("You have selected option 3");
                    Positive_Negative_SumAndAverage();
                    break;
                case 4:
                    Console.WriteLine("You have selected option 4");
                    Zero_Placement();
                    break;
                case 5:
                    Console.WriteLine("You have selected option 5");
                    LSNumber();
                    break;
                case 6:
                    Console.WriteLine("You have selected option 6");
                    duplication();
                    break;

                case 7:
                    Non_Repeating();
                    break;


                default:
                    Console.WriteLine("Please choice right option");
                    break;

            }

        }
        //Positive_Negative_SumAndAverage function

        static void Positive_Negative_SumAndAverage()
        {
            Console.WriteLine("Enter the range of input to be give");
            int Length_array = Convert.ToInt32(Console.ReadLine());//taking input for the length of array
            int[] array = new int[Length_array];
            Console.WriteLine("Enter " + Length_array + " numbers");
            for (int i = 0; i < Length_array; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            int Positive = 0, Negaitive = 0, Sum = 0;
            Double Average = 0;//in the form of decimal
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > 0) { Positive = Positive + 1; }
                else { Negaitive = Negaitive + 1; }
                Sum = Sum + array[j];
                Average = Sum / array.Length;
            }

            Console.WriteLine("Sum: " + Sum);
            Console.WriteLine("No of Positive: " + Positive);
            Console.WriteLine("No of Negative: " + Negaitive);
            Console.Write("Average: " + Average);
        }

        static void Zero_Placement()
        {
            Console.WriteLine("the given array is {1,2,0,5,0,9}");
            int[] array = { 1, 2, 0, 5, 0, 9 };
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
        //armstrong number function
        static void ArmStrong()
        {
            Console.WriteLine("Enter a number to check wether its a armstrong number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = n; i > 0; i = i / 10)//we will keep orgianl number and checking the condition
            {
                int reminder = i % 10;
                sum = sum + (reminder * reminder * reminder);//finding the cube root and adding them 
            }

            if (sum == n)//checking the sum and the orignal number 
            {
                Console.WriteLine(n + " is armstrong number");
            }
            else
            {
                Console.WriteLine("The given number is not a armstrong number");
            }
        }

        //non repeating number
        static void Non_Repeating()
        {
            Console.WriteLine("Enter a String:");
            string wordInput = Console.ReadLine();
            char firstNonRepeatingChar = '\0';
            int[] charCount = new int[256]; // Assuming ASCII characters

            // Count the occurrences of each character
            for (int i = 0; i < wordInput.Length; i++)
            {
                char ch = wordInput[i];
                charCount[ch]++;
            }

            // Find the first non-repeating character
            for (int i = 0; i < wordInput.Length; i++)
            {
                char ch = wordInput[i];
                if (charCount[ch] == 1)
                {
                    firstNonRepeatingChar = ch;
                    break;
                }
            }

            if (firstNonRepeatingChar != '\0')
            {
                Console.WriteLine("The first not repeating is: " + firstNonRepeatingChar);
            }
            else
            {
                Console.WriteLine("There is no non-repeating character.");
            }
        }




        //remove duplication
        static void duplication()
        {
            Console.WriteLine("Enter the range of input to be give");
            int Length_array = Convert.ToInt32(Console.ReadLine());//taking input for the length of array
            int[] Orginal_Array = new int[Length_array];
            Console.WriteLine("Enter " + Length_array + " numbers");
            for (int k = 0; k < Length_array; k++)
            {
                Orginal_Array[k] = Convert.ToInt32(Console.ReadLine());

            }
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


        //first and second largest number
        static void LSNumber()
        {
            Console.WriteLine("Enter the range of input to be give");
            int Length_array = Convert.ToInt32(Console.ReadLine());//taking input for the length of array
            int[] array = new int[Length_array];
            Console.WriteLine("Enter " + Length_array + " numbers");
            for (int i = 0; i < Length_array; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

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
        }

        //Fibonacci_sequence function
        static void Fibonacci_sequence(int length)
        {
            int num1 = 0, num2 = 1, num3 = 0;
            for (int i = 2; i < length; i++)
            {

                num3 = num1 + num2;
                Console.Write(num3);
                num1 = num2;
                num2 = num3;


            }
        }

    }
}