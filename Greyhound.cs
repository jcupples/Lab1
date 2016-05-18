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

        

        public bool Run() //use randomizer like in the sub shop example
        {
            //Random Randomizer = new Random();

            int randomMovement = Randomizer.Next(1, 4);

            Point currentPos = myPictureBox.Location;
            currentPos.X += randomMovement;
            myPictureBox.Location = currentPos;

                    //Move forward either 1,2, 3, or 4 spaces at random
                    //update the position of my picture box on form
                    //return true if I won the race

            if (currentPos.X >= RaceTrackLength)
            {
                return true;
            }
            else
                return false;
           
        }

        public void TakeStartingPosition()
        {
            //reset location to the start line
            myPictureBox.Left = StartingPosition;
            Location = 0;
        }

    }
}
