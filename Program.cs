using System;
using ConsoleBasketball.Actions;

namespace ConsoleBasketball
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Basketball
            Greeting greeting = new Greeting();
            greeting.DisplayGreeting();

            string userName = greeting.GetUser();
            greeting.DisplayRules(userName);

            PlayGame newGame = new PlayGame();
            newGame.StartGame(userName);
        }
    }
}
