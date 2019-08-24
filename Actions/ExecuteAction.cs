using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ConsoleBasketball.Entities;

namespace ConsoleBasketball.Actions
{
    class ExecuteAction
    {
        Player player = new Player();
        GameAction g = new GameAction();

        // Ticker
        public void Ticker(int timing)
        {
            Thread.Sleep(timing);
            Console.Write(".");
            Thread.Sleep(timing);
            Console.Write(".");
            Thread.Sleep(timing);
            Console.Write(".");
        }

        public void ScoringAction(string description, int timerMS, int odds, int probability, int amount, string outcomeGood, string outcomeMiss)
        {
            Console.Write(description);
            Ticker(timerMS);

            if(odds <= probability)
            {
                Console.WriteLine(outcomeGood);
                player.totalpts += amount;
            }
            else
            {
                Console.WriteLine(outcomeMiss);
            }
        }

        // Scoring
        public void FreeThrow(int odds)
        {
            g._description = "The Free Throw attempt is up";
            g._timerMS = 400;
            g._odds = odds;
            g._probability = 8;
            g._amount = 1;
            g._outcomeGood = "It's good!\n+" + g._amount + " points. ";
            g._outcomeMiss = "No good!";

            ScoringAction(g._description, g._timerMS, g._odds, g._probability, g._amount, g._outcomeGood, g._outcomeMiss);
        }

        public void Layup(int odds)
        {
            g._description = "Goes up for the layup";
            g._timerMS = 200;
            g._odds = odds;
            g._probability = 9;
            g._amount = 2;
            g._outcomeGood = "It's good!\n+" + g._amount + " points. ";
            g._outcomeMiss = "No good!";

            ScoringAction(g._description, g._timerMS, g._odds, g._probability, g._amount, g._outcomeGood, g._outcomeMiss);
        }

        public void Dunk(int odds)
        {
            g._description = "Attacks the hoop for the dunk";
            g._timerMS = 150;
            g._odds = odds;
            g._probability = 10;
            g._amount = 2;
            g._outcomeGood = "Slams it home!\n+" + g._amount + " points. ";
            g._outcomeMiss = "No good!";

            ScoringAction(g._description, g._timerMS, g._odds, g._probability, g._amount, g._outcomeGood, g._outcomeMiss);
        }

        public void ThreePointer(int odds)
        {
            g._description = "From way downtown";
            g._timerMS = 500;
            g._odds = odds;
            g._probability = 5;
            g._amount = 3;
            g._outcomeGood = "It's good!\n+" + g._amount + " points. ";
            g._outcomeMiss = "No good!";

            ScoringAction(g._description, g._timerMS, g._odds, g._probability, g._amount, g._outcomeGood, g._outcomeMiss);
        }

        // Rebounds
        public void Rebound()
        {
            Console.WriteLine("+ 1 Rebound");
            player.totalrebs += 1;
        }

        // Assists
        public void Assist()
        {
            Console.WriteLine("+ 1 Assist");
            player.totalasts += 1;
        }
        
        // View Stats
        public void ViewStats()
        {
            Console.WriteLine("Points: " + player.totalpts);
            Console.WriteLine("Rebounds: " + player.totalrebs);
            Console.WriteLine("Assists: " + player.totalasts);
        }

    }
}
