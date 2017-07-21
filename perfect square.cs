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

    Console.WriteLine("Perfect Numbers");

    Console.Write("Value is: ");
    int Value = Convert.ToInt32(Console.ReadLine());

    Console.Write("Number of length: ");
    int length = Convert.ToInt32(Console.ReadLine());

    Console.Write("The positive divisor are ");
    for (int i = 1; i <= length; i++)
    {
        if (Value % i == 0 && i != Value)
             {      
                 Console.Write("{0} ",i);
                 sum += i;
             }            
    }
    //int answer = sum - Value;
    Console.WriteLine("\nThere sum is {0}.",sum);
    Console.WriteLine(" ");
      
       
       }
    }
} 