using System;


namespace c
{
    class Program
    {
        public static void Main(string[] args)
        {
          
        Console.WriteLine("Value of two numbers to be divide are: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        try 
        {
            int div = a/b;
            Console.WriteLine("Answer is {0}.", div);  
        }
        
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Dividing by zero is not acceptable so making denominator 1");
            int divide = a / 1;
            Console.WriteLine("So Answer will now be {0}.",divide);
        }
          
        
        }
    }
    
}
      
      
      