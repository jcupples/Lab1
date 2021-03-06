﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    class Guy
    {

        public string name; //the guy's name
        public Bet myBet = null; //an instance of Bet() that has his bet
        public int cash; //how much cash he has

        public RadioButton myRadioButton;
        public Label myLabel;

        public void UpdateLabels()
        {
            //set my label to my bet's description, and the label on my
            // radio button to show my cash ('Joe has 43 bucks')

            if (myBet == null)
            {
                myLabel.Text = name + " hasn't placed a bet";
            }
            else {
                myLabel.Text = myBet.GetDescription();
            }

            myRadioButton.Text = name + " has " + cash + " bucks";
      
        }
        public void ClearBet() 
        {
            //clear the betting table
            myBet.amount = 0;
        }

        public bool PlaceBet(int amount, int Dog)
        {
                myBet = new Bet();
                myBet.Dog = Dog;
                myBet.amount = amount;
                myBet.Bettor = this;
                UpdateLabels();
               //testing
           

            //place a new bet and store it in my bet field
            //return true if the guy had enough money to bet

            if (amount >= cash)
            {
                return false;
            }
            else
                return true;
        }

        public void Collect(int Winner) {
            cash += myBet.PayOut(Winner);
        } //ask my bet to pay out
    }
}

