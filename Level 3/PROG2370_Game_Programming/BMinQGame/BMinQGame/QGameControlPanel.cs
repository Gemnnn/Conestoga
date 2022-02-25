/*
 * 
 * Program ID: Assignment 2
 * 
 * Purpose: Game programming
 * 
 * Revision History:
 *      created by Byounguk Min Nov 4, 2021
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

namespace BMinQGame
{
    public partial class QGameControlPanel : Form
    {
        
        /// <summary>
        /// Base
        /// </summary>
        public QGameControlPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start making design mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DesignForm design_Form = new DesignForm();
            design_Form.Visible = true;
        }

        /// <summary>
        /// Quit the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
