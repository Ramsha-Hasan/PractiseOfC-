using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
    string username = "Ramsha";
    string password = "ramsha02";
    int numOfAttempt = 3;

    Console.WriteLine("Enter the username: ");
    string inputUsername = Console.ReadLine();
    Console.WriteLine("Enter password");
    string inputPassword = Console.ReadLine();

    
        if (inputUsername != username || inputPassword != password)
        {
                TryAgain();
        
        }
        
        else
        {
        Console.WriteLine("Success !");
        }
         
         }
    
    public static void TryAgain()
    {
            Console.WriteLine("Enter the username: ");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Enter password");
            string inputPassword = Console.ReadLine();
            string username = "Ramsha";
            string password = "ramsha02";

             if (inputUsername != username || inputPassword != password)
        {
               
        Console.WriteLine("Try Again Later !");
        }
        
        else
        {
        Console.WriteLine("Success !");
        }

            
    }

    }
} 
       