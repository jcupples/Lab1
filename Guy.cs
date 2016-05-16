using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    class Guy
    {

        public string name; //the guy's name
        public Bet myBet; //an instance of Bet() that has his bet
        public int cash; //how much cash he has

        public RadioButton myRadioButton;
        public Label myLabel;

        public void UpdateLabels()
        {
            //set my label to my bet's description, and the label on my
            

            // radio button to show my cash ('Joe has 43 bucks')
      
        }
        public void ClearBet() 
        {
            //clear the betting table
            myBet.amount = 0;
        }

        public bool PlaceBet(int amount, int Dog)
        {
            Bet myBet = new Bet();

            //place a new bet and store it in my bet field
            //return true if the guy had enough money to bet
        }

        public void Collect(int Winner) { } //ask my bet to pay out
    }
}

