using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleBasketball.Actions
{
    class Greeting
    {
        public void DisplayGreeting()
        {
            // Greeting
            Console.WriteLine("========================");
            Console.WriteLine("CONSOLE BASKETBALL 2019");
            Console.WriteLine("========================");
            Console.Write("What is your name? ");
        }

        public string GetUser()
        {
            // Get username
            string userName = Console.ReadLine();
            return userName;
        }

        public void DisplayRules(string userName)
        {
            Console.WriteLine("\nWelcome, " + userName + "! See below for the rules:\n");

            // Display rules
            Console.WriteLine("Actions: Free Throw (F), Dunk (D), Layup (L), Three Pointer (T), Rebound (R), Assist(A).");
            Console.WriteLine("To quit type Q.");
            Console.WriteLine("To view current stats type S.\n");
            Console.Write("What do you want to do? ");
        }


    }
}
