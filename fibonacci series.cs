using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
    int firstTerm = 0;
    int SecondTerm = 1;  
    int term = 0;   
    Console.WriteLine("Fibonacci series");
    Console.Write("\nEnter number of terms ");
    int terms = Convert.ToInt32(Console.ReadLine());


Console.Write("{0} {1} ",firstTerm,SecondTerm);
for (int i = 3; i <= terms; i++)
{
    term = firstTerm+SecondTerm;
    Console.Write("{0} ",term);
    firstTerm = SecondTerm;
    SecondTerm = term;
}

       }
    }
} 
       