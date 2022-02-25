/*
 * Program ID: Assignment 1
 * 
 * Purpose: Game programming
 * 
 * Revision History:
 *      created by Byounguk Min Oct 3, 2021
 * 
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

namespace BMinAssignment1
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        // Go to the main screen from the game title page
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameScreen game = new GameScreen();
            game.Visible = true;
        }

        // Show the developer
        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Byounguk Min");
        }

        // Timer setting to give effect to the title screen
        private void TitleScreen_Load(object sender, EventArgs e)
        {
            timer1.Interval = 450;
            timer1.Start();
        }

        // effect effect according to the timer setting
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
                pictureBox1.Visible = false;
            else
                pictureBox1.Visible = true;
        }

        // Start or restart the game
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult restart = MessageBox.Show("Do you want to restart the game?", "", MessageBoxButtons.YesNo);
            if (restart == DialogResult.Yes)
            {
            }
            else if (restart == DialogResult.No)
            {
            }
        }

        // End the game
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
