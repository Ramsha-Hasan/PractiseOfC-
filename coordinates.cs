using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
Console.WriteLine("Enter coordinates");
int coordinate1 = Convert.ToInt32(Console.ReadLine());
int coordinate2 = Convert.ToInt32(Console.ReadLine());
if (coordinate1 > 0 && coordinate2 > 0)
{
    Console.WriteLine("Coordinate 1");
}
else if (coordinate1 < 0 && coordinate2 > 0)
{
    Console.WriteLine("Coordinate 2");
}
else if (coordinate1 < 0 && coordinate2 < 0)
{
    Console.WriteLine("Coordinate 3");
}
else
{
    Console.WriteLine("Coordinate 4");
}
        
       }

    }
} 
       