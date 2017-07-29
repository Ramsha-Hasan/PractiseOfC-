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
    int i;  
       Console.Write("\nReversing elements of an array:");
       Console.Write("Input elements in the array :\n");  
    for(i = 0; i < 10; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    array[i] = Convert.ToInt32(Console.ReadLine());  		
    }  
  
    Console.Write("\nElements in array are: ");  
    for(i = 0; i < 10; i++)  
    {  
        Console.Write("{0}  ", array[i]);  
    }  

    Console.Write("\nElements in reverse order are: ");
      for(i = 9; i >= 0; i--)  
    {  
        Console.Write("{0}  ", array[i]);  
    }       
       }
    }
}