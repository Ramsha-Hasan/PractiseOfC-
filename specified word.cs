using System;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
     
      Console.Write("Specified String Tester ");
      string data = Console.ReadLine();


 
     if(data.Contains("Hello") || data.Contains("hello") || data.Contains("HELLO"))
     {
          Console.WriteLine("Input string contain the specified word 'HELLO' ");
     }
    
    else 
    {
         Console.WriteLine("Input string doesnot contain the specified word 'HELLO' ");
    }
   
     
       }
   
    }

}   
