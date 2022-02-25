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
    public partial class GameScreen : Form
    {
        string turn = "X";
        string[,] gameTable = new string[3, 3];
        int countTurn = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        // Click the button and the game will be recorded in the array
        // Each time the button is clicked, the total number of plays is recorded
        private void button_Click(object sender, EventArgs e)
        {
            countTurn++;
            Button button = (Button)sender;
            button.Enabled = false;

            int rowCount = tlpTable.GetRow(button);
            int columnCount = tlpTable.GetColumn(button);
            gameTable[rowCount, columnCount] = turn;

            if (turn == "X")
            {
                button.BackgroundImage = BMinAssignment1.Properties.Resources.x;
                turn = "O";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = turn + "'s turn.....";
            }
            else
            {
                button.BackgroundImage = BMinAssignment1.Properties.Resources.o;
                turn = "X";
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Text = turn + "'s turn.....";
            }
            lineCheck();
            drawCheck();
        }

        /// <summary>
        /// Check each line to see if you have the victory requirements.
        /// Remove empty space in the array before checking winner.
        /// </summary>
        public void lineCheck()
        {
            //Remove empty space(null) in the array
            for (int i = 0; i < gameTable.GetLength(0); i++)
            {
                for (int j = 0; j < gameTable.GetLength(1); j++)
                {
                    if (gameTable[i, j] == null)
                    {
                        gameTable[i, j] = "";
                    }
                }
            }
            // Check a horizontal line
            if (gameTable[0, 0].Equals(gameTable[0, 1]) && gameTable[0, 1].Equals(gameTable[0, 2]) && !btn1.Enabled)
            {
                winnerCheck();
            }
            else if (gameTable[1, 0].Equals(gameTable[1, 1]) && gameTable[1, 1].Equals(gameTable[1, 2]) && !btn4.Enabled)
            {
                winnerCheck();
            }
            else if (gameTable[2, 0].Equals(gameTable[2, 1]) && gameTable[2, 1].Equals(gameTable[2, 2]) && !btn7.Enabled)
            {
                winnerCheck();
            }

            // Check a vertical line
            else if (gameTable[0, 0].Equals(gameTable[1, 0]) && gameTable[1, 0].Equals(gameTable[2, 0]) && !btn1.Enabled)
            {
                winnerCheck();
            }
            else if (gameTable[0, 1].Equals(gameTable[1, 1]) && gameTable[1, 1].Equals(gameTable[2, 1]) && !btn2.Enabled)
            {
                winnerCheck();
            }
            else if (gameTable[0, 2].Equals(gameTable[1, 2]) && gameTable[1, 2].Equals(gameTable[2, 2]) && !btn3.Enabled)
            {
                winnerCheck();
            }

            // Check a diagonal line
            else if (gameTable[0, 0].Equals(gameTable[1, 1]) && gameTable[1, 1].Equals(gameTable[2, 2]) && !btn1.Enabled)
            {
                winnerCheck();
            }
            else if (gameTable[0, 2].Equals(gameTable[1, 1]) && gameTable[1, 1].Equals(gameTable[2, 0]) && !btn7.Enabled)
            {
                winnerCheck();
            }
        }

        // Default settings on game load
        private void GameScreen_Load(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
            lblMessage.Text = "X's turn.....";
        }

        /// <summary>
        /// Disables the button when the game ends
        /// </summary>
        private void disableButton()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        /// <summary>
        /// Activates the button when the game starts
        /// </summary>
        private void EnableButton()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        /// <summary>
        /// Determine the draw of the game
        /// </summary>
        public void drawCheck()
        {
            if (countTurn == 9)
            {
                MessageBox.Show("Draw Game");
                reset();
                return;
            }
        }

        /// <summary>
        /// After checking the victory requirements of each line, 
        /// a message box is displayed to indicate the winner.
        /// </summary>
        public void winnerCheck()
        {
            disableButton();
            drawCheck();
            if (turn == "X")
            {
                turn = "O";
            }
            else turn = "X";

            MessageBox.Show(turn + " won");
            reset();
        }

        /// <summary>
        /// Reset everything to restart the game
        /// </summary>
        public void reset()
        {
            EnableButton();
            btn1.BackgroundImage = null;
            btn2.BackgroundImage = null;
            btn3.BackgroundImage = null;
            btn4.BackgroundImage = null;
            btn5.BackgroundImage = null;
            btn6.BackgroundImage = null;
            btn7.BackgroundImage = null;
            btn8.BackgroundImage = null;
            btn9.BackgroundImage = null;
            Array.Clear(gameTable, 0, gameTable.Length);
            turn = "X";
            lblMessage.Text = turn + "'s turn.....";
            countTurn = 0;
        }

        // Start or restart the game
        public void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult restart = MessageBox.Show("Do you want to restart the game?", "", MessageBoxButtons.YesNo);
            if (restart == DialogResult.Yes)
            {
                reset();
            }
            else if (restart == DialogResult.No)
            {

            }
        }

        // Clase the game
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Show the developer
        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Byounguk Min");
        }
    }
}
