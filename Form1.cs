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

        Guy joe;
        Guy bob;
        Guy al;

        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { cash = 50, name = "Joe" };
            bob = new Guy() { cash = 75, name = "Bob" };
            al = new Guy() { cash = 45, name = "Al" };


        }
    }
}
