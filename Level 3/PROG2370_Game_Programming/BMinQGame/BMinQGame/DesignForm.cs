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

using BMinQGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMinQGame
{
    public partial class DesignForm : Form
    {
        // Field fixed value
        const int GENERATE_TOP = 100;
        const int GENERATE_LEFT = 200;
        const int WIDTH = 50;
        const int HEIGHT = 50;
        const int SPACE = 3;

        // Global variable
        int numberOfColums;
        int numberOfRows;
        Image image = null;
        int imageNumber = 0;
        Field[,] fields;
        CurrentField currentField = new CurrentField();

        /// <summary>
        /// Field's type
        /// </summary>
        public enum FieldType
        {
            none,
            wall,
            door,
            box
        }

        /// <summary>
        /// Tool's color
        /// </summary>
        public enum ToolColor
        {
            none,
            black,
            red,
            green
        }

        /// <summary>
        /// Base
        /// </summary>
        public DesignForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a grid based on user input
        /// Check the user's input is correct and display and error message if it's incorrect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGernerate_Click(object sender, EventArgs e)
        {
            bool errorCheck = false;


            if (!int.TryParse(txtColums.Text, out numberOfColums))
            {
                errorCheck = true;
            }
            if (!int.TryParse(txtRows.Text, out numberOfRows))
            {
                errorCheck = true;
            }

            if (errorCheck == true)
            {
                MessageBox.Show("Please provide vaild data for rows and colums (Both must be integers)", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fields = new Field[numberOfRows, numberOfColums];
                int x = GENERATE_LEFT;
                int y = GENERATE_TOP;

                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int j = 0; j < numberOfColums; j++)
                    {
                        Field field = new Field();
                        field.Top = y;
                        field.Left = x;
                        field.Width = WIDTH;
                        field.Height = HEIGHT;
                        field.BackColor = Color.Transparent;
                        field.BorderStyle = BorderStyle.FixedSingle;
                        field.SizeMode = PictureBoxSizeMode.StretchImage;

                        field.Click += Field_Click;

                        this.Controls.Add(field);
                        fields[i, j] = field;

                        x += WIDTH + SPACE;
                    }
                    y += HEIGHT + SPACE;
                    x = GENERATE_LEFT;
                }
            }
        }

        /// <summary>
        /// Enter the tool selected in the toolbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Field_Click(object sender, EventArgs e)
        {
            Field field = sender as Field;
            field.Image = image;
            field.imageNumber = imageNumber;
            field.toolColor = currentField.toolColor;
            field.fieldType = currentField.fieldType;
        }

        /// <summary>
        /// Tool selected by the user
        /// Each tool has their own character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolBoxButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            image = button.Image;
            imageNumber = button.ImageIndex;

            switch (((Button)sender).Name)
            {
                case "btnNone":
                    currentField.fieldType = FieldType.none.ToString();
                    currentField.toolColor = ToolColor.none.ToString();
                    break;
                case "btnWall":
                    currentField.fieldType = FieldType.wall.ToString();
                    currentField.toolColor = ToolColor.black.ToString();
                    break;
                case "btnRedDoor":
                    currentField.fieldType = FieldType.door.ToString();
                    currentField.toolColor = ToolColor.red.ToString();
                    break;
                case "btnGreenDoor":
                    currentField.fieldType = FieldType.door.ToString();
                    currentField.toolColor = ToolColor.green.ToString();
                    break;
                case "btnRedBox":
                    currentField.fieldType = FieldType.box.ToString();
                    currentField.toolColor = ToolColor.red.ToString();
                    break;
                case "btnGreenBox":
                    currentField.fieldType = FieldType.box.ToString();
                    currentField.toolColor = ToolColor.green.ToString();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Save the design and display a message when it is done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.bm)|*.bm|ALL files (*.*)|*.*";
            int wall = 0;
            int door = 0;
            int box = 0;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false))
                    {
                        writer.WriteLine(numberOfRows);
                        writer.WriteLine(numberOfColums);

                        for (int i = 0; i < numberOfRows; i++)
                        {
                            for (int j = 0; j < numberOfColums; j++)
                            {
                                if (fields[i, j].fieldType == "wall")
                                {
                                    wall++;
                                }
                                if (fields[i, j].fieldType == "door")
                                {
                                    door++;
                                }
                                if (fields[i, j].fieldType == "box")
                                {
                                    box++;
                                }

                                writer.WriteLine(i);
                                writer.WriteLine(j);
                                writer.WriteLine(fields[i, j].imageNumber);
                            }
                        }
                    }
                    
                    MessageBox.Show("File saved Successfully" + "\n"
                        + "Total number of walls: " + wall + "\n"
                        + "Total number of doors: " + door + "\n"
                        + "Total number of boxes: " + box + "\n", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, try again", ex);
            }
        }
    }
}
