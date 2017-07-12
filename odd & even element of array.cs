using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

int[] givenArray = new int[5];

Console.WriteLine("Enter the elements: ");

for (int i = 0; i < givenArray.Length; i++)
{
    givenArray[i]=Convert.ToInt32(Console.ReadLine());   
}
Console.WriteLine("Given array is [{0}].",string.Join(", ",givenArray));

Console.WriteLine("");

Console.WriteLine(evenodd(givenArray));

       }

public static bool evenodd (int[] givenArray)
{

    foreach (var item in givenArray)
    {
    if (item % 2 != 0)
    return true;
    }
    return false;
}


        
   
    }

} 