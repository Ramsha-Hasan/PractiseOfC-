using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
   
  
   Console.Write("Input number of rows : ");
   int rows= Convert.ToInt32(Console.ReadLine());    


   Console.WriteLine("Full pyramid with *");
   int space=rows+4-1;
   for(int i=1;i<=rows;i++)
   {
         for(int k=space;k>=1;k--)
            {
              Console.Write(" ");
            }
                      
	   for(int j=1;j<=i;j++)
	   Console.Write("* ");
	Console.Write("\n");
    space--;
   }

Console.Write("");
Console.WriteLine("Full pyramid with numbers");   
int spaceAgain = rows+4-1;
for(int i=1;i<=rows;i++)
   {
         for(int k=spaceAgain;k>=1;k--)
            {
              Console.Write(" ");
            }
                      
	   for(int j=1;j<=i;j++)
	   Console.Write("{0} ",j);
	Console.Write("\n");
    spaceAgain--;
   }
   
       }
    }
} 