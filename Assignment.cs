using System;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Sum of 2 numbers");
            Console.WriteLine("2. Check Even number");
            Console.WriteLine("3. Check if a year is a leap year");
            Console.WriteLine("4. Convert kilometer per hour to miles per hour");
            Console.WriteLine("5. Check whether the number is buzz or not");
            Console.WriteLine("6. Table");
            Console.WriteLine("7. Factorial");
            Console.WriteLine("8. Find Prime number");
            Console.WriteLine("9. Check triangle type");
            Console.WriteLine("10. Pattern");
            Console.WriteLine("11. Palindrome");
            Console.WriteLine("12. Exit");
            Console.Write("Enter your choice: ");

            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            switch (choice)
            {
                case 1:
                    Console.Write("Enter First number: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second number: ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sum of 2 numbers: " + Sum(num1, num2));
                    break;
                case 2:
                    Console.Write("Enter a number: ");
                    int evenNumber = int.Parse(Console.ReadLine());
                    Even(evenNumber);
                    break;
                case 3:
                    Console.Write("Please enter a year: ");
                    int year = int.Parse(Console.ReadLine());
                    Leapyear(year);
                    break;
                case 4:
                    Console.Write("Please enter kilometers per hour: ");
                    double kmph = double.Parse(Console.ReadLine());
                    Console.WriteLine("Conversion to miles per hour: " + Convert(kmph) + " mph");
                    break;
                case 5:
                    Console.Write("Please enter a number: ");
                    int buzzNumber = int.Parse(Console.ReadLine());
                    Buzz(buzzNumber);
                    break;
                case 6:
                    Console.Write("Please enter a number: ");
                    int tableNum = int.Parse(Console.ReadLine());
                    Table(tableNum);
                    break;
                case 7:
                    Console.Write("Please enter a number: ");
                    int factNum = int.Parse(Console.ReadLine());
                    factorial(factNum);
                    break;
                case 8:
                    Console.Write("Please enter a number: ");
                    int primeNum = int.Parse(Console.ReadLine());
                    Prime(primeNum);
                    break;
                case 9:
                    Console.Write("Please enter three sides of a triangle (separated by spaces): ");
                    string[] sides = Console.ReadLine().Split();
                    int side1 = int.Parse(sides[0]);
                    int side2 = int.Parse(sides[1]);
                    int side3 = int.Parse(sides[2]);
                    Triangle(side1, side2, side3);
                    break;
                case 10:
                    pattern();
                    break;
                case 11:
                    Console.Write("Please enter a number: ");
                    int palNum = int.Parse(Console.ReadLine());
                    palindrome(palNum);
                    break;
                case 12:
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }

            Console.WriteLine(); // Adding a blank line for better readability

        } while (choice != 12); // Continue loop until choice is 12 (Exit option)
    }

    // Sum of two numbers
    static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    // Check if number is even
    static void Even(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine(num + " is an even number.");
        }
        else
        {
            Console.WriteLine(num + " is not an even number.");
        }
    }

    // Convert kilometers per hour to miles per hour
    static double Convert(double kmph)
    {
        return kmph * 0.621371;
    }

    // Check if a year is a leap year
    static void Leapyear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }

    // Check if number is a buzz number
    static void Buzz(int num)
    {
        if (num % 7 == 0 || num % 10 == 7)
        {
            Console.WriteLine(num + " is a buzz number.");
        }
        else
        {
            Console.WriteLine(num + " is not a buzz number.");
        }
    }

    // Print multiplication table
    static void Table(int n)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }

    // Calculate factorial of a number
    static void factorial(int num)
    {
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        Console.WriteLine("Factorial of " + num + " = " + fact);
    }

    // Check if number is prime
    static void Prime(int num)
    {
        bool isPrime = true;

        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine(num + " is a prime number.");
        }
        else
        {
            Console.WriteLine(num + " is not a prime number.");
        }
    }

    // Check type of triangle
    static void Triangle(int s1, int s2, int s3)
    {
        if (s1 == s2 && s2 == s3)
        {
            Console.WriteLine("Equilateral triangle");
        }
        else if (s1 == s2 || s2 == s3 || s3 == s1)
        {
            Console.WriteLine("Isosceles triangle");
        }
        else
        {
            Console.WriteLine("Scalene triangle");
        }
    }

    // Print a simple pattern
    static void pattern()
    {
        int rows = 5;
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Check if number is palindrome
    static void palindrome(int num)
    {
        int result = 0;
        int quotient = num;

        while (num > 0)
        {
            int remainder = num % 10;
            result = result * 10 + remainder;
            quotient = quotient / 10;
        }

        if (result == num)
        {
            Console.WriteLine(result + " is a palindrome.");
        }
        else
        {
            Console.WriteLine(result + " is not a palindrome.");
        }
    }
}
