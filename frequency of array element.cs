using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
int size,i,j,count;
Console.Write("\nTo count the frequency of elements of array");

Console.Write("\n\nEnter the size of array ");
size = Convert.ToInt32(Console.ReadLine());

//array 1

int[] array = new int[size];
Console.Write("\nInput elements:\n\n");
for (i = 0; i < size; i++)
{
    Console.Write("Element {0}: ",i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("\nArray is: ");
for (i = 0; i < size; i++)
{
    Console.Write("{0} ",array[i]);
}

//Countarray

int[] countArray = new int[size];
for (i = 0; i < size; i++)
{
    countArray[i] = -1;
}

for (i = 0; i < size; i++)
{   count = 1;
    for (j = i+1; j < size; j++)
    {
        if(array[i] == array[j])
        {
            countArray[j] = 0;
            count++;
        }
    }
     if(countArray[i]!=0) 
     {  
        countArray[i] = count;  
     } 
}

 for(i = 0; i < size; i++) 
 {  
    if(countArray[i] != 0) 
    {  
        Console.Write("\nElement {0} : Count {1}\n", array[i], countArray[i]);  
    }  
 }
       }
    }
}