using System;

namespace c
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter the number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            
            int sum = number1 + number2;
        
            bool condition = number1 == 20 || number2 == 20 || sum == 20;
            
            Console.WriteLine("According to condition its {0}",condition);
            
            
            }
    }
    
}
      
      
      