using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

      int p ; 
      int q ;
      Console.WriteLine("Floyd's Triangle");
      Console.WriteLine(" ");
      Console.Write("Enter number of rows ");
      int rows = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= rows ; i++)
{
    if (i % 2 == 0)
    {
        p = 1;
        q = 0;
    }
    else
    {
        p = 0;
        q = 1;
    }
    Console.WriteLine(" ");
    for (int j = 1; j <= i; j++)
    {
       if (j % 2 == 0)
       {
           Console.Write("{0}",p); 
       }
       else
       {
           Console.Write("{0}",q); 
       }
    }
}
      
    Console.WriteLine(" ");
      
       
       }
    }
} 
       