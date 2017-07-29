using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
          
    int[] array = new int[10]; 
    int i, sum = 0;  
       Console.Write("\nReversing elements of an array:");
       Console.Write("Input elements in the array :\n");  
    for(i = 0; i < 10; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    array[i] = Convert.ToInt32(Console.ReadLine()); 
        sum += array[i]; 		
    }  
  
    Console.Write("\nElements in array are: ");  
    for(i = 0; i < 10; i++)  
    {  
        Console.Write("{0}  ", array[i]);  
    }  

   Console.Write("\nSum of all array element is: {0}",sum);

         
       }
    }
}