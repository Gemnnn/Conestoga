﻿/*
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMinQGame
{
    /// <summary>
    /// Field property
    /// </summary>
    public class Field : PictureBox
    {
        public int imageNumber { get; set; }

        public string toolColor { get; set; }

        public string fieldType { get; set; }

    }
}
