using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

    double seriesSum = 0; 
    double answer = 0;
    Console.WriteLine("Sum of series X - X^3 + X^5 + X^7 + ...");
    
    
    Console.Write("Value of X: ");
    int X = Convert.ToInt32(Console.ReadLine());

    Console.Write("Number of terms: ");
    int terms = Convert.ToInt32(Console.ReadLine());

    Console.Write("{0}^1 - ",X);

    for (int i = 3; i <= 2*terms; i++)
    {
        if (i % 2 != 0)
        {
         seriesSum = seriesSum + Math.Pow(X,i) ;  
        
        Console.Write("{0}^{1} + ",X,i);
        }
        
    }
    Console.WriteLine(seriesSum);
    answer = seriesSum - X;
    Console.WriteLine("\nAnswer of series is {0}.",answer);
    Console.WriteLine(" ");
      
       
       }
    }
} 
       