using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
    int i,remainder,sum,number;
    int start,end;
         
    Console.Write("starting number: ");
    start = Convert.ToInt32(Console.ReadLine());	

    Console.Write("ending number: ");
    end = Convert.ToInt32(Console.ReadLine());	

    Console.Write("Armstrong numbers are: ");
    for(i = start; i <= end; i++)
    {
         number=i;
         sum = 0;

         while(number != 0)
         {
             remainder=number % 10;
             number=number/10;
             sum=sum+(remainder*remainder*remainder);
         }
        if(sum==i)
            Console.Write(i);
    }
    Console.WriteLine(" ");
      
       
       }
    }
} 
       