using System;


namespace c
{
    class Program
    {
        public static void Main(string[] args)
        {
       
       Console.WriteLine("Swapping Of Numbers");
       Console.WriteLine("");

       Console.WriteLine("Enter First Number:");
       int firstNumber = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("");

       Console.WriteLine("Enter Second Number:");
       int secondNumber = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("");
       
       Console.WriteLine("After Swapping:");
       Console.WriteLine("First Number is {0}",secondNumber);
       Console.WriteLine("Second Number is {0}",firstNumber);
        
        }
    }
    
}