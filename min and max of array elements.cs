using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
int size,i;
Console.Write("\nTo find the max and min of elements of array");

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

Console.WriteLine("\n");
Console.WriteLine("Minimum number is {0}",array.Min());

Console.WriteLine("\n");
Console.WriteLine("Maximum number is {0}",array.Max());
       }
    }
} 
       
