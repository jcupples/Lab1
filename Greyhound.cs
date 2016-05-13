using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication6
{
    class Greyhound
    {

        public int StartingPosition; //Where my picturebox starts
        public int RaceTrackLength; //how long the racetrack is
        public PictureBox myPictureBox = null; //my picturebox object
        public int Location = 0; //My location on racetrack
        public Random Randomizer; //instance of Random

        public int[] Dog = new int[4];

        public bool Run()
        {
            //intialize new randomizer
            //Randomizer = new Random();

            while (isWinner == false)
            {
                for (int i = 1; i < Dog.Length; i++)
                {
                    Randomizer = new Random();
                    //Move forward either 1,2, 3, or 4 spaces at random
                    //update the position of my picture box on form
                    //return true if I won the race
                }
            }
        }

        public void TakeStartingPosition()
        {
            //reset location to the start line
            Location = 0;
        }

    }
}
