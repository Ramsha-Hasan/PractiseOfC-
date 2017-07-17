using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
           Console.WriteLine("Half Pyramid Using Numbers");
           Console.WriteLine("");
           Console.WriteLine("Half Pyramid 1");
       for (int i = 1; i <= 5; i++)
       {
           Console.WriteLine("");
           for (int j = 1; j <= i; j++)
           {
               Console.Write(" {0}",j);
           }
       }
       Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Half Pyramid 2");
        for (int i = 1; i <= 5; i++)
        {
          Console.WriteLine("");
          for (int j = 1; j <= 5+1-i; j++)
          {
            Console.Write(" {0}",j);
          }
        }

       }
    }
} 
       