// Assignment 4
// Name: Byounguk Min
// Student Number: 8703561
// Date: 5 April, 2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4_byounguk_min
{
    public partial class StockMaintenance : Form
    {
        public StockMaintenance()
        {
            InitializeComponent();
        }

        string previousStockId = "";

        // Sorts and displays the list of list boxes
        // Even though there is no data and also if data remains in the input field, the input field is initialized.
        private void LoadListBox(object sender, EventArgs e)
        {
            try
            {
                List<BMStock> stocks = BMStock.BMGetStocks();
                stocks = stocks.OrderBy(a => a.Name).ToList();

                lstRecord.DisplayMember = "Name";
                lstRecord.ValueMember = "StockId";
                lstRecord.DataSource = stocks;
            }
            catch (Exception ex)
            {
                lblMessage.Text = ("[Exception] - Load list box : " + ex.Message);
            }
        }

        // This function changes the displayed data according to the selected data
        private void lstRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BMStock bMStocks = BMStock.BMGetByStockId(Convert.ToInt32(lstRecord.SelectedValue));

                txtStockId.Text = bMStocks.StockId.ToString();
                txtName.Text = bMStocks.Name;
                txtDescription.Text = bMStocks.Description;
                txtPrice.Text = bMStocks.Price.ToString();
                txtMinutes.Text = bMStocks.Minutes.ToString();
                chkProcedure.Checked = bMStocks.IsProcedure;
            }
            catch (Exception ex)
            {
                lblMessage.Text = ("[Exception] - List box select : " + ex.Message);
            }
        }

        // This is a command that is executed when the program is first executed
        // reset message boxes and a list box
        // If there is no information to be displayed in the listbox, a message is displayed
        private void StockMaintenance_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            LoadListBox(sender, e);
            if (lstRecord.SelectedIndex == -1)
            {
                txtStockId.Text = "0";
                lblMessage.Text = "There is no data to be displayed.";
            }
        }

        // Clean up the input area for new records
        private void btnClearInput_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            txtStockId.Text = "0";
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtMinutes.Text = "";
            chkProcedure.Checked = false;

            lblMessage.Text = "This is a new record.";
        }

        // Save the data and call Add or Update according to the data situation
        // All error messages are displayed at once
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            previousStockId = txtStockId.Text;
            BMStock stock = new BMStock();

            stock.StockId = Convert.ToInt32(txtStockId.Text);
            stock.Name = txtName.Text;
            stock.Description = txtDescription.Text;

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                lblMessage.Text += "Price is must be numeric.\n";
            }
            if (!int.TryParse(txtMinutes.Text, out int minutes))
            {
                lblMessage.Text += "Minutes are must be numberic.\n";
            }
            if (lblMessage.Text != "")
            {
                return;
            }

            stock.Price = price;
            stock.Minutes = minutes;
            stock.IsProcedure = chkProcedure.Checked;

            try
            {
                if (txtStockId.Text == "0")
                {
                    stock.BMAdd();
                    lblMessage.Text = "Data Add is completed.";
                    LoadListBox(sender, e);
                    lstRecord.SelectedValue = stock.StockId;
                }
                else
                {
                    stock.BMUpdate();
                    lblMessage.Text = "Data Update is completed.";
                    LoadListBox(sender, e);
                    lstRecord.SelectedValue = stock.StockId;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ("[Exception] - Save : " + ex.Message);
            }
        }

        // Delete specific data
        // After the data has been removed, the focus is properly provided for the convenience of the user
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            previousStockId = txtStockId.Text;
            int listIndexOfMemory = lstRecord.SelectedIndex;

            try
            {
                BMStock.BMDelete(txtStockId.Text);
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }

            LoadListBox(sender, e);

            if (lstRecord.Items.Count == 0)
            {
                btnClearInput_Click(sender, e);
            }
            else if (listIndexOfMemory == lstRecord.Items.Count)
            {
                lstRecord.SelectedIndex = lstRecord.Items.Count - 1;
            }
            else
            {
                lstRecord.SelectedIndex = listIndexOfMemory;
            }
            lblMessage.Text = "Data has been deleted successfully.";
        }

        // It remembers the situation before the user modifies or deletes
        // the data and returns it to the previous situation when the button is executed
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                File.Copy(BMStock.archive, BMStock.fileName, true);
                LoadListBox(sender, e);
                if (previousStockId == "0")
                {
                    btnClearInput_Click(sender, e);
                }
                else
                {
                    lstRecord.SelectedValue = Convert.ToInt32(previousStockId);
                }          
            }
            catch (Exception ex)
            {
                throw new Exception("[Exception] - Cancel : " + ex.Message);
            }
            lblMessage.Text = "Cancellation has been executed.";
        }

        // Exit the program
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // This is an event handler to prevent errors that may be caused by Enter in the Description section
        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
