using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
        
        int answer = 0;
        int squared = 0;
         
      
      Console.WriteLine("To calculate the square of natural numbers");
      Console.WriteLine(" ");
      Console.Write("Enter number of terms ");
      int terms = Convert.ToInt32(Console.ReadLine());


      Console.WriteLine(" ");
      Console.Write("Square of {0} terms are ",terms);

for (int i = 1; i <= terms ; i++)
{
    squared = i * i;
    
    Console.Write("{0} ",squared);
    answer += squared;
}
      
    Console.WriteLine("\nTheir sum is {0}.",answer);
    
    Console.WriteLine(" ");
      
       
       }
    }
}