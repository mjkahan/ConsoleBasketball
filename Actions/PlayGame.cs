using System;
using System.Collections.Generic;
using System.Text;
using ConsoleBasketball.Entities;
using System.Threading;

namespace ConsoleBasketball.Actions
{
    class PlayGame
    {
        public void StartGame(string user)
        {
            ExecuteAction gameOn = new ExecuteAction();

            // Play game
            int liveGame = 1;

            do
            {
                string action = Console.ReadLine().ToLower();
                Random attempt = new Random();
                int odds = attempt.Next(1, 11);

                switch (action)
                {
                    case "f":
                        gameOn.FreeThrow(odds);
                        Console.Write("\nWhat next? ");
                        break;
                    case "d":
                        gameOn.Dunk(odds);
                        Console.Write("\nWhat next? ");
                        break;
                    case "l":
                        gameOn.Layup(odds);
                        Console.Write("\nWhat next? ");
                        break;
                    case "t":
                        gameOn.ThreePointer(odds);
                        Console.Write("\nWhat next? ");
                        break;
                    case "r":
                        gameOn.Rebound();
                        Console.Write("\nWhat next? ");
                        break;
                    case "a":
                        gameOn.Assist();
                        Console.Write("\nWhat next? ");
                        break;
                    case "s":
                        Console.Write("\n" + user + "'s stats: \n");
                        gameOn.ViewStats();
                        Console.Write("\nWhat next? ");
                        break;
                    case "q":
                        Console.WriteLine("Thanks for playing! Goodbye!");
                        Thread.Sleep(2000);
                        liveGame = 0;
                        break;
                    default:
                        Console.Write("\nTry again ");
                        break;
                }
            }
            while (liveGame == 1);

            System.Environment.Exit(1);
        }

    }
}
