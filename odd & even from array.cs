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
Console.Write("\nTo find the even and odd elements of array");

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

Console.WriteLine(" ");

Console.Write("\nOdd numbers are ");
    for (i = 0; i < size; i++)
    {
         if (array[i] % 2 == 1)
            {
                Console.Write("{0} ",array[i]);
            }
    }


Console.WriteLine(" ");

Console.Write("\nEven numbers are ");
    for (i = 0; i < size; i++)
    {
         if (array[i] % 2 == 0)
            {
                Console.Write("{0} ",array[i]);
            }
    }
       }
    }
} 
