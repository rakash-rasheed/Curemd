using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        //function for fibonacci_Series
        static void fibonacci_Series(int num)
        {

            int f1 = 0, f2 = 1, f3 = 0;
            for (int i = 0; i <= num; i++)
            {
                f3 = f1 + f2;//finding the sum 
                Console.WriteLine(f3);
                f1 = f2;//shifting the values 
                f2 = f3;//shifting the values 
            }

            Console.ReadLine();
        }

        // function to find the largest and second largest number

        static void Largest_secondNumber()
        {
            int[] array = { 2, 3, 14, 1, 6, 5, 9 };
            int largest_number = 0;
            int SLargest_number = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largest_number)
                {
                    SLargest_number = largest_number;// Update second largest with previous largest
                    largest_number = array[i]; // Update largest number

                }
                else if (array[i] > SLargest_number && array[i] != largest_number)
                {
                    SLargest_number = array[i]; // Update second largest if found a new candidate
                }

            }
            Console.WriteLine("largest number:" + largest_number);
            Console.WriteLine("Second number:" + SLargest_number);
            Console.ReadLine();
        }

        //Duplication
        static void Duplication()
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
            Console.ReadLine();
        }

        //function for zero at the end
        static void zero()
        {
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
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int option;
            do
            {

                Console.WriteLine("1- To find fibonacci series ");
                Console.WriteLine("2- To find Largest and second largest number ");
                Console.WriteLine("3- To Ruplication from array ");
                Console.WriteLine("4- Place zeros at the end of array ");
                string userInput = Console.ReadLine();
                option = int.Parse(userInput);
                switch (option)
                {
                    case 1:
                        Console.Write("enter number find fibonacci series");
                        int Userinput = int.Parse(Console.ReadLine());
                        fibonacci_Series(Userinput);//calling the function 
                        break;
                    case 2:
                        Largest_secondNumber();
                        break;
                    case 3:
                        Duplication();
                        break;
                    case 4:
                        zero();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                }

                Console.WriteLine();

            } while (option != 4); // loop will Continue until user select 12
        }

    }

}