using System;


namespace c
{
    class Program
    {
        public static void Main(string[] args)
        {
          
        Console.WriteLine("Value of two numbers to be summed are: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a+b;
        Console.WriteLine("Answer is {0}.", sum);  
        
        }
    }
    
}