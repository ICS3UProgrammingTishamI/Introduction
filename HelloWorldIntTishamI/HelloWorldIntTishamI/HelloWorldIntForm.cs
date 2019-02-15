/*
 * Created by: Tisham Islam
 * Created on: 08/02/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World international
 * This program that displays different forms of "Hello World" in different languages using various radio buttons.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldIntTishamI
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        //These all change the label to "Hello World" when the button is clicked on, but in differing languages. 
        private void radBangla_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "ওহে বিশ্ব";
        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Hello, World!";
        }

        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Bonjour, tout le monde!";
        }

        private void radSpanish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Hola, Mundo!";
        }

        private void radCanadian_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Hockey hockey, ice rink!";
        }

        private void radLatin_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Salve, Orbis Terrarum";
        }

        private void lblHelloWorldInt_Click(object sender, EventArgs e)
        {

        }
    }
}
