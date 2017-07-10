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
            bool answer = number1>0 && number2<0 || number1<0 && number2>0;
            
            Console.WriteLine("Condition: {0}",answer);
        }
    }
    
}
      
      
      