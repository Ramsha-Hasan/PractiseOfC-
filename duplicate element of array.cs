using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
          
    int[] array = new int[5]; 
    
    int i,j;
       
       Console.Write("Input elements in the array :\n");  
    for(i = 0; i < 5; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    array[i] = Convert.ToInt32(Console.ReadLine()); 		
    }  
  
    Console.Write("\nElements in array are: ");  
    for(i = 0; i < 5; i++)  
    {  
        Console.Write("{0}  ", array[i]);  
    } 

       Console.Write("\nDuplicate elements in array is: ");  
    for(i = 0; i < 5; i++)  
    {  
        for (j = i+1; j < 5; j++)
        {
          if (array[i] == array[j])
          {
             Console.Write("{0}  ", array[i]);  
          }
        } 
    }        

       }
    }
} 