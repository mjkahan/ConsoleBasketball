using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleBasketball.Entities
{
    class GameAction
    {
        public string _description { get; set; }
        public int _timerMS { get; set; }
        public int _odds { get; set; }
        public int _probability { get; set; }
        public int _amount { get; set; }
        public string _outcomeGood { get; set; }
        public string _outcomeMiss { get; set; }
    }
}
