// Program ID: Venue Booking
// Purpose: Assignment1
// Name: Byounguk Min
// Student Number: 8703561

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1_Byounguk_Min
{
    public partial class Venue_Booking : Form
    {
        string[,] reservations = new string[5, 6];
        string[] waiting = new string[10];
        string customerName = "";
        Boolean seatsAvailable = true;
        Boolean waitingAvailable = true;
        public Venue_Booking()
        {
            InitializeComponent();
        }

        // Checks for empty parts of the array.
        public bool CheckNullContained(string[,] stringArray)
        {
            bool nullCheck = false;

            foreach (string item in stringArray)
            {
                if (item == null)
                {
                    nullCheck = true;
                }
            }
            return nullCheck;
        }

        // Checks for empty parts of the array.
        public bool CheckNullContained(string[] stringArray)
        {
            bool nullCheck = false;

            foreach (string item in stringArray)
            {
                if (item == null)
                {
                    nullCheck = true;
                }
            }
            return nullCheck;
        }

        // Initialize the message at program startup.
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        // Record the customer's name and seat number in the reservation list (in array)
        // When the reservation is complete, the reservation list is automatically updated.
        // If the seat has already been reserved, 
        // the reservation will not be executed and the available seats will be displayed in the message box.
        private void btnBook_Click(object sender, EventArgs e)
        {
            string errors = "";
            int rowIndex = lstRow.SelectedIndex;
            int seatIndex = lstSeat.SelectedIndex;
            customerName = txtCustomerName.Text;
            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Red;

            seatsAvailable = CheckNullContained(reservations);

            if (!seatsAvailable)
            {
                lblMessage.Text += "There are no seats available for reservation.\n" +
                                   "Click the \"Add to Waiting\" button to place your name on the waiting list.";
                return;
            }
            if (lstRow.SelectedIndex == -1)
            {
                if (errors == "") lstRow.Focus();
                errors += "Please select a Row.\n";
            }
            if (lstSeat.SelectedIndex == -1)
            {
                if (errors == "") lstSeat.Focus();
                errors += "Please select a seat.\n";
            }
            if (txtCustomerName.Text.Length == 0)
            {
                if (errors == "") txtCustomerName.Focus();
                errors += "Please enter the customer name.\n";
            }
            if (reservations[rowIndex, seatIndex] != null)
            {
                lblMessage.Text += "There are customers who are already booked.\nPlease choose another seat.\n[Available seats]: ";
                for (int i = 0; i < reservations.GetLength(0); i++)
                {
                    string row1 = lstRow.Items[i].ToString();
                    for (int j = 0; j < reservations.GetLength(1); j++)
                    {
                        string seat1 = lstSeat.Items[j].ToString();
                        if (string.IsNullOrEmpty(reservations[i, j]))
                        {
                            lblMessage.Text += row1 + seat1 + ", ";
                        }
                    }
                }
            }
            else
            {
                reservations[rowIndex, seatIndex] = customerName;
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Record Saved";
            }
            btnShowAll_Click(sender, e);
        }

        // Updates the currently reserved list.
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            seatsAvailable = false;
            rtbReservations.Text = "";
            for (int i=0; i < reservations.GetLength(0); i++)
            {
                string row = lstRow.Items[i].ToString();
                for (int j=0; j<reservations.GetLength(1); j++)
                {
                    string seat = lstSeat.Items[j].ToString();
                    if (string.IsNullOrEmpty(reservations[i, j]))
                        seatsAvailable = true;
                    rtbReservations.Text += row + seat + " - " + reservations[i, j] + "\n";
                }
            }
        }

        // Allows customers to put their name on the waiting list when the reservation is full.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            customerName = txtCustomerName.Text;
            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Red;
            seatsAvailable = CheckNullContained(reservations);
            waitingAvailable = CheckNullContained(waiting);

            if (seatsAvailable)
            {
                lblMessage.Text += "There are seats available for reservation.";    
            }
            else if (!waitingAvailable)
            {
                lblMessage.Text += "The waiting list is full.";
            }
            else if (string.IsNullOrEmpty(customerName))
            {
                lblMessage.Text += "Please enter your name in the 'Customer Name' field.";
            }
            else
            {
                for (int i = 0; i < waiting.Length; i++)
                {
                    if (waiting[i] == null)
                    {
                        waiting[i] = customerName;

                        lblMessage.ForeColor = Color.Green;
                        lblMessage.Text += "Record saved.";

                        break;
                    }
                }
            }
            btnShowAll_Click(sender, e);
            btnShowWaiting_Click(sender, e);
        }

        // End program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Cancel a reserved customer by popping up a message box.
        // If the reservation name and record are not the same, it will not be executed.
        // If there is a name on the reservation list, it will be automatically reserved for an empty seat.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string errors = "";
            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Red;
            int rowIndex = lstRow.SelectedIndex;
            int seatIndex = lstSeat.SelectedIndex;
            customerName = txtCustomerName.Text;

            if (lstRow.SelectedIndex == -1)
            {
                if (errors == "") lstRow.Focus();
                errors += "Please select a Row.\n";
            }
            if (lstSeat.SelectedIndex == -1)
            {
                if (errors == "") lstSeat.Focus();
                errors += "Please select a seat.\n";
            }
            if (txtCustomerName.Text.Length == 0)
            {
                if (errors == "") txtCustomerName.Focus();
                errors += "Please enter the customer name.\n";
            }
            string seatReserved = lstRow.Items[rowIndex].ToString() + lstSeat.Items[seatIndex].ToString();
            if (reservations[rowIndex,seatIndex] == null)
            {
                lblMessage.Text += seatReserved + " seat has not booked yet.";
            }
            else if (customerName != reservations[rowIndex, seatIndex])
            {
                lblMessage.Text += "List and name do not match.";
            }
            else
            {
                string messageBox = "Name: " + reservations[rowIndex, seatIndex] + "\n" + 
                    "Reserved Seat: " + seatReserved + "\n\n" + 
                    "Are you sure you want to cancel the reservation?";
                string answer = MessageBox.Show(messageBox, "Cancel Reservation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
                if (answer == "Yes")
                {
                    if (waiting[0] != null)
                    {
                        reservations[rowIndex, seatIndex] = waiting[0];
                        for (int i = 0; i < waiting.Length; i++)
                        {
                            if (i < (waiting.Length - 1))
                            {
                                waiting[i] = waiting[i + 1];
                            }
                            else
                            {
                                waiting[i] = null;
                            }
                        }
                        lblMessage.Text += "The reservation under " + seatReserved + " has been canceled.\n";
                    }
                    else
                    {
                        reservations[rowIndex, seatIndex] = null;
                        lblMessage.Text += "The reservation under " + seatReserved + " has been canceled.";
                    }
                }
            }
            btnShowAll_Click(sender, e);
            btnShowWaiting_Click(sender, e);
        }

        // Automatically fill all seats.
        private void btnDebug_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Green;

            for (int i = 0; i < reservations.GetLength(0); i++)
            {
                for (int j = 0; j < reservations.GetLength(1); j++)
                {
                    reservations[i, j] = "Name";
                }
            }

            for (int i = 0; i < waiting.Length; i++)
            {
                waiting[i] = null;
            }
            btnShowAll_Click(sender, e);
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "All seats are full";
        }

        // Update the waiting list.
        private void btnShowWaiting_Click(object sender, EventArgs e)
        {
            rtbWaiting.Text = "";

            for (int i = 0; i < waiting.Length; i++)
            {
                rtbWaiting.Text += waiting[i] + "\n";
            }
        }
    }
}
