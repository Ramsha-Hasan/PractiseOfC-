using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
        //int sum = 0;
        
        Console.Write("Enter the term: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        float sumCalc = 0.0f;
        
        for (int i = 1; i <= n; i++)        
        {
            Console.Write("1/{0} + ",i);
            sumCalc = sumCalc + (1/(float)i);
        }
          Console.WriteLine("\nSum is {0}",sumCalc);
       }
    }
}