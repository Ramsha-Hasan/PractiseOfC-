using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
        int factorial = 1;
        Console.Write("Finding factorial of ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("Factorial of {0} is {1}",number,factorial);
       }
    }
} 