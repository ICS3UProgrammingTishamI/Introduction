/*
 * Created by: Tisham Islam
 * Created on: 2019/02/07
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - School App
 * This program displays our school and our mascot (the Saints), with an exit menu
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

namespace SchoolAppTishamI
{
    public partial class frmSchoolApp : Form
    {
        public frmSchoolApp()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //this closes the entire form
            this.Close();
        }
    }
}
