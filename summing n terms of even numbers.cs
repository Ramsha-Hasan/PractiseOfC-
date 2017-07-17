using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
        int sum = 0;
        Console.WriteLine("Summing n terms of even numbers");
        Console.Write("Enter the term: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Summing {0} terms of even numbers",n);
        for (int i = 1; i <= 2*n; i++)        
        {
            if (i % 2 == 0)
            {
                sum = sum + i;
                
            }
        }
        Console.WriteLine("Sum is {0}",sum);
       }
    }
} 
       