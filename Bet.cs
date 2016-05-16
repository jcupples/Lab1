using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication6
{
    class Bet
    {
        public int amount; //amount of cash that was bet
        public int Dog; //The number of the dog the bet is on
        public Guy Bettor; //the guy who placed the bet

        public string GetDescription()
        {
            //return a string that says who placed the bet, how much
            //cash was bet, and which dog he bet on ("Joe bets 8 on
            //dog #4"). If the amount is zero, no bet was placed
            //("Joe hasn't placed a Bet.")
            if (amount > 0)
            {
                return Bettor.name + " bets " + amount + " bucks on dog #" + Dog;
            }
            else
                return Bettor.name + " hasn't placed a bet";
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return amount;
            }
            else
	        {
                return -amount;
	        }
            //the parameter is the winner of the race. if the dog won, 
            //returns the amount bet. Otherwise, return the negative of
            //the amount bet. 
        }
    }
}
