/*
 * Created by: Tisham Islam
 * Created on: 11/02/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Perimeter, Area, Volume
 * This program calculates the perimeter of a rectangle, the area of a circle and the volume of a sphere.
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

namespace PerAreaVolTisham
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        //These bits of code calculates the various parts of the program, and display the calculations once the button has been clicked on
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            lblRectangleAnswer.Text = Convert.ToString((9 + 12) * 2) + "cm";
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            lblCircleAnswer.Text = Convert.ToString(Math.PI * Math.Pow(10,2)) + "m^2";
        }

        private void btnSphere_Click(object sender, EventArgs e)
        {
            lblSphereAnswer.Text = Convert.ToString(Math.PI * (double)4 / (double)3 * Math.Pow(42, 3)) + "km^3";
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblTest.Text = Convert.ToString(4.0 / 3.0);
        }
    }
}
