using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
   Console.WriteLine("To check the number is prime or not");
   Console.Write("\nEnter the number ");
   int number = Convert.ToInt32(Console.ReadLine());
   int prime = 0;

   for (int i = 1; i <= number; i++)
   {
       if (number % i == 0)
       {
           prime++;
       }
   }
   if (prime == 2)
   {
       Console.WriteLine("Its a prime number");
   }
else
{
    Console.WriteLine("Its not a prime number");
}
    Console.WriteLine(" ");
      
       
       }
    }
} 
       