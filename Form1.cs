using System;
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


        public Form1()
        {
            InitializeComponent();

            //guys object initialization
            guys[0] = new Guy() 
            { 
                cash = 50, 
                myLabel = label4, 
                myRadioButton = joeRadioButton, 
                name = "Joe" 
            };

            guys[1] = new Guy() 
            {
                cash = 75, 
                myLabel = label5, 
                myRadioButton = bobRadioButton, 
                name = "Bob" 
            };

            guys[2] = new Guy() 
            {
                cash = 45, 
                myLabel = label6, 
                myRadioButton = alRadioButton, 
                name = "Al" 
            };
           

            //dogs picturebox initialization

            dogs[0].myPictureBox = dogPictureBox1;
            dogs[1].myPictureBox = dogPictureBox2;
            dogs[2].myPictureBox = dogPictureBox3;
            dogs[3].myPictureBox = dogPictureBox4;
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            
                if (sender == alRadioButton)
                {

                    if (!guys[2].PlaceBet((int)betNumericUpDown.Value, (int)dogNumericUpDown.Value)) 
                    {
                        //display message saying you can't bet that amount	
                        MessageBox.Show("You can not bet this amount.", "Unable to bet amount");
                    }
                }
                else if (sender == joeRadioButton)
                {
                    if (!guys[0].PlaceBet((int)betNumericUpDown.Value, (int)dogNumericUpDown.Value))
                    {
                        //display message saying you can't bet that amount	
                        MessageBox.Show("You can not bet this amount.", "Unable to bet amount");
                    }
                }
                else if (sender == bobRadioButton)
                {
                    if (!guys[1].PlaceBet((int)betNumericUpDown.Value, (int)dogNumericUpDown.Value))
                    {
                        //display message saying you can't bet that amount	
                        MessageBox.Show("You can not bet this amount!", "Unable to bet amount");
                    }
                }
                //Update the labels
         }

        private void raceButton_Click(object sender, EventArgs e)
        {

            bool noWinner = true;
            int dogWon;

                while (noWinner)
	            {
	                for (int i = 0; i < dogs.Length; i++)
			            {
			                if(dogs[i].Run()) {
                                dogWon = i + 1;
                            }
			            }        
	            }
         }
	}
};

