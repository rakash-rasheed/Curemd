using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rakash");
            even(10);  //call even number function    
            Console.Write(sum(5, 9));//sum of two numbers
        }
        //function for even number 
        static void even(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i.ToString());
            }
        }

        //sum of 2 numbers
        static int sum(int number1, int number2)
        {
            int total = number1 + number2;
            return total;
            Console.ReadLine();

        }
    }
}