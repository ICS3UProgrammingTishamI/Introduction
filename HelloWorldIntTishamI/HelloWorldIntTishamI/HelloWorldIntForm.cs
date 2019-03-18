/*
 * Created by: Tisham Islam
 * Created on: 08/02/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World International
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

        //This changes it to Bangla
        private void radBangla_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "ওহে বিশ্ব";
        }

        //This changes it to english
        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Hello, World!";
        }

        //This changes it to french
        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Bonjour, tout le monde!";
        }

        //this changes it to spanish
        private void radSpanish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Hola, Mundo!";
        }

        //This changes to a extremly inaccurate stereotypical representation of how canadians speak
        private void radCanadian_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Hockey hockey, ice rink!";
        }

        //This changes it to latin
        private void radLatin_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Salve, Orbis Terrarum";
        }
    }
}
