using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
       Console.WriteLine("In Words Game");
       int number = Convert.ToInt32(Console.ReadLine());

      
       
         switch (number)
       {
           case 1:
           Console.WriteLine("One");
           break;

           case 2:
           Console.WriteLine("Two");
           break;

           case 3:
           Console.WriteLine("Three");
           break;

           case 4:
           Console.WriteLine("Four");
           break;

           case 5:
           Console.WriteLine("Five");
           break;

           case 6:
           Console.WriteLine("Six");
           break;

           case 7:
           Console.WriteLine("Seven");
           break;

           default:
           Console.WriteLine("Invalid Number");
           break;
       }
       
     
        
       }

    }
} 
       