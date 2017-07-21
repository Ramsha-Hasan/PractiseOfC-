using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
           int number, remainder, sum = 0;
           Console.Write("Armstrong number for 3 digit number");
            Console.Write("\nenter the Number ");
            number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i = i / 10)
            {
                Console.WriteLine("i is {0} ",i);
                remainder = i % 10;
                Console.WriteLine("remainder is {0} ",remainder);
                sum = sum + remainder*remainder*remainder;
                Console.WriteLine("Their sum is {0}",sum);
 
            }
            if (sum == number)
            {
                Console.Write("Entered Number is an Armstrong Number");
            }
            else
                Console.Write("Entered Number is not an Armstrong Number");
    Console.WriteLine(" ");
      
       
       }
    }
} 
       