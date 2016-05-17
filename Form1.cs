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

            //dogs
        }

        private void betButton_Click(object sender, EventArgs e)
        {

        }

        private void raceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
