﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {

        //initialize dog and guy arrays
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];
        Random myRandom = new Random();


        public Form1()
        {
            InitializeComponent();

            //guys object initialization
            guys[0] = new Guy()
            {
                cash = 50,
                myLabel = joeBetLabel,
                myRadioButton = joeRadioButton,
                name = "Joe"
                
            };

            guys[1] = new Guy()
            {
                cash = 75,
                myLabel = bobBetLabel,
                myRadioButton = bobRadioButton,
                name = "Bob"
            };

            guys[2] = new Guy()
            {
                cash = 45,
                myLabel = alBetLabel,
                myRadioButton = alRadioButton,
                name = "Al",
                
            };

            for (int i = 0; i < guys.Length; i++)
            {
                guys[i].UpdateLabels();
            }
          


            //dogs object
            dogs[0] = new Greyhound()
            {
                myPictureBox = dogPictureBox1,
                StartingPosition = raceTrackPictureBox.Left,
                RaceTrackLength = raceTrackPictureBox.Width - dogPictureBox1.Width,
                Randomizer = myRandom
            };

            dogs[1] = new Greyhound()
            {
                myPictureBox = dogPictureBox2,
                StartingPosition = raceTrackPictureBox.Left,
                RaceTrackLength = raceTrackPictureBox.Width - dogPictureBox2.Width,
                Randomizer = myRandom
            };

            dogs[2] = new Greyhound() 
            {
                myPictureBox = dogPictureBox3,
                StartingPosition = raceTrackPictureBox.Left,
                RaceTrackLength = raceTrackPictureBox.Width - dogPictureBox3.Width,
                Randomizer = myRandom
            };

            dogs[3] = new Greyhound()
            {
                myPictureBox = dogPictureBox4,
                StartingPosition = raceTrackPictureBox.Left,
                RaceTrackLength = raceTrackPictureBox.Width - dogPictureBox4.Width,
                Randomizer = myRandom
            };

          
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            
            if (joeRadioButton.Checked)
            {
                guys[0].PlaceBet((int)betNumericUpDown.Value, (int)dogNumericUpDown.Value);
            }

            if (bobRadioButton.Checked)
            {
                guys[1].PlaceBet((int)betNumericUpDown.Value, (int)dogNumericUpDown.Value);
            }

            if (alRadioButton.Checked)
            {
                guys[2].PlaceBet((int)betNumericUpDown.Value, (int)dogNumericUpDown.Value);
            }


        }

        private void raceButton_Click(object sender, EventArgs e)
        {

            bool noWinner = false;
            int dogWon;

            while (!noWinner)
            {
               Application.DoEvents();

                for (int i = 0; i < dogs.Length; i++)
                {
                    if (dogs[i].Run())
                    {
                        dogWon = i +1;
                        MessageBox.Show("The Winner is dog #" + dogWon, "Winner!");
                        for (int j = 0; j < dogs.Length; j++)
                        {
                            dogs[j].TakeStartingPosition();
                        }
                    }
                }

                //Application.DoEvents();
            }
        }
        //testing
        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = guys[0].name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = guys[1].name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = guys[2].name;
        }
    }
};

