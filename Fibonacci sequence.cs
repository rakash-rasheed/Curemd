// C# code to implement the approach
using System;

class GFG
{

	// Method to calculate the nth fibonacci number
	public static int fibonacci_numbers(int n)
	{
		if (n == 0)
		{
			return 0;
		}
		else if (n == 1)
		{
			return 1;
		}
		else
		{
			return fibonacci_numbers(n - 2) + fibonacci_numbers(n - 1);
		}
	}


	// Driver Code
	public static void Main(string[] args)
	{
		int n = 7;
		for (int i = 0; i < n; i++)
		{
			// Function call
			Console.Write(fibonacci_numbers(i) + " ");
		}
	}
}


// This code is contributed by phasing17
