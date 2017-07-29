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
    int[] array2 = new int[5];
    int i;
       
       Console.Write("Input elements in the array :\n");  
    for(i = 0; i < 5; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    array[i] = Convert.ToInt32(Console.ReadLine()); 
        array2[i] = array[i];		
    }  
  
    Console.Write("\nElements in array are: ");  
    for(i = 0; i < 5; i++)  
    {  
        Console.Write("{0}  ", array[i]);  
    }         

      Console.Write("\n\nDuplicate array is: "); 
      for (i = 0; i < 5; i++)
      {
      Console.Write("{0}  ",array2[i]); 
      }

       }
    }
} 