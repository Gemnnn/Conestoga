// Assignment 3
// Name: Byounguk Min
// Student Number: 8703561
// Date: 17 March, 2021

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

namespace assignment3_byounguk_Min
{
    public partial class StockPortfolioTracker : Form
    {
        string filePath;
        string fileName;
        string record;
        string errorMessage;
        int transactionId;
        StreamWriter writer;
        StreamReader reader;
        bool foundIf = false;
        bool isAdd = true;
        public StockPortfolioTracker()
        {
            InitializeComponent();
        }

        // When running the program, the maximum value of the date 
        // that can be set by the user is set so that it cannot be in the future.
        private void StockPortfolioTracker_Load(object sender, EventArgs e)
        {
            transactionDate.MaxDate = DateTime.Today;
        }

        // Create a file with the specified path.
        // If there is a file, the existing file is reused/opened.
        private void btnCreat_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            txtData.Text = "";

            if (string.IsNullOrWhiteSpace(txtPath.Text))
            {
                txtMessages.Text = "File name and path section should be filled";
                return;
            }
            if (File.Exists(txtPath.Text))
            {
                fileName = txtPath.Text;
                btnDisplay_Click(sender, e);
                txtMessages.Text = "A file previously saved with the same name is opened";
            }
            else
            {
                try
                {
                    filePath = Path.GetDirectoryName(txtPath.Text);
                    fileName = Path.GetFileName(txtPath.Text);
                    
                    if (string.IsNullOrWhiteSpace(fileName))
                    {
                        txtPath.Focus();
                        txtMessages.Text = "File name should be existed";
                        return;
                    }
                    else if (!string.IsNullOrWhiteSpace(filePath))
                    {
                        if (!Directory.Exists(filePath))
                        {
                            Directory.CreateDirectory(filePath);
                            File.Create(txtPath.Text).Dispose();
                            txtMessages.Text = "A new file has been created";
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtMessages.Text = "[Exception] - Create: " + ex.Message;
                }

                fileName = txtPath.Text;
            }
        }

        // Create a new Transaction ID.
        // Transaction ID displays the next number based on the existing file.
        // If there is no Transaction ID data, the first number is loaded.
        private void btnGetNewId_Click(object sender, EventArgs e)
        {
            List<int> order = new List<int>();

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        order.Add(Convert.ToInt32(reader.ReadLine().Substring(0,5).Trim()));
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "[Exception] - Get New Id StreamReader: " + ex.Message;
            }
            try
            {
                if (order.Count == 0)
                {
                    txtAddId.Text = "1";
                    txtAddId.SelectAll();
                    txtMessages.Text = "Since there are no records, the first number is automatically generated.";
                    return;
                }
                if (order.Contains(1) && order.Count == 1)
                {
                    txtAddId.Text = "2";
                    txtAddId.SelectAll();
                    txtMessages.Text = "Next transaction ID has been created";
                }
                for (int i = 1; i < order.Max(); i++)
                {
                    if (!order.Contains(i))
                    {
                        txtAddId.Text = i.ToString();
                        txtAddId.SelectAll();
                        txtMessages.Text = "Transaction ID has been created";
                        break;
                    }
                    else
                    {
                        txtAddId.Text = (i + 2).ToString();
                        txtAddId.SelectAll();
                        txtMessages.Text = "Next transaction ID has been created";
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "[Exception] - Get New Id Record Check: " + ex.Message;

            }
        }

        // This function cleans up spaces before and after input values.
        private string StringTrim(string input)
        {
            input = (input + "").Trim();
            return input;
        }

        // The information entered by the user is checked and recorded in a text file.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string transactionType = "";
            string date = "";
            int ofShares = 0;
            double sharePrice = 0;
            double commissions = 0;
            double totalAssetValue;
            double totalTransactionValue;
            errorMessage = "";
            txtMessages.Text = "";

            // Transaction ID
            if (string.IsNullOrWhiteSpace(txtAddId.Text))
            {
                errorMessage += "Transaction ID must be required\n";
            }
            else if (!int.TryParse(txtAddId.Text.ToString(), out transactionId))
            {
                errorMessage += "Transaction ID must be numeric\n";
            }
            else if (transactionId < 0)
            {
                errorMessage += "Transaction ID must be greater than zero\n";
            }
            else
            {
                foundIf = false;
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        if (record.StartsWith(transactionId.ToString()))
                        {
                            foundIf = true;
                            break;
                        }
                    }
                    if (isAdd && foundIf)
                    {
                        errorMessage += "Transaction ID is already on file\n";
                    }
                    else if (!isAdd && !foundIf)
                    {
                        errorMessage += "Transaction ID being updated is not on file\n";
                    }
                }
            }

            // Ticker symbol
            StringTrim(txtAddSymbol.Text);
            if (string.IsNullOrWhiteSpace(txtAddSymbol.Text))
            {
                errorMessage += "Ticker Symbol must be required\n";
            }
            else

            // Company
            StringTrim(txtAddCompany.Text);
            if (string.IsNullOrWhiteSpace(txtAddCompany.Text))
            {
                errorMessage += "Company must be required\n";
            }

            // Transaction Type
            if (!rdoBuy.Checked && !rdoSell.Checked)
            {
                errorMessage += "Transaction Type must be checked\n";
            }
            else if (rdoBuy.Checked)
            {
                transactionType = "Buy";
            }
            else if (rdoSell.Checked)
            {
                transactionType = "Sell";
            }

            // Date
            if (transactionDate.Value > DateTime.Now)
            {
                errorMessage += "Date can not be in the future\n";
            }
            else
            {
                date = transactionDate.Value.ToString("M'/'dd'/'yyyy");
            }

            // Notes
            string notes = StringTrim(txtAddNotes.Text);
            if (string.IsNullOrWhiteSpace(notes))
            {
                errorMessage += "Notes must be required\n";
            }

            // Share price
            if (string.IsNullOrWhiteSpace(txtAddSharePrice.Text))
            {
                errorMessage += "Share price must be required\n";
            }
            else if (!double.TryParse(txtAddSharePrice.Text, out sharePrice))
            {
                errorMessage += "Share price must be numeric\n";
            }
            else if (sharePrice < 0)
            {
                errorMessage += "Share price must be greater than zero\n";
            }

            // # of shares
            if (string.IsNullOrWhiteSpace(txtAddOfShares.Text))
            {
                errorMessage += "# of shares must be required\n";
            }
            else if (!int.TryParse(txtAddOfShares.Text, out ofShares))
            {
                errorMessage += "# of shares must be numeric\n";
            }
            else if (ofShares < 0)
            {
                errorMessage += "# of shares must be greater than zero\n";
            }

            // Commission
            if (string.IsNullOrWhiteSpace(txtAddCommission.Text))
            {
                errorMessage += "Commission must be required\n";
            }
            else if (!double.TryParse(txtAddCommission.Text, out commissions))
            {
                errorMessage += "Commission must be numeric\n";
            }
            else if (ofShares < 0)
            {
                errorMessage += "Commission must be greater than zero\n";
            }

            // Focus
            txtMessages.Text = ErrorFocus(errorMessage);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return;
            }

            // Total Stock
                totalAssetValue = sharePrice * ofShares;
            // Total Stock with commission
                totalTransactionValue = totalAssetValue - commissions;

            record = transactionId.ToString().PadRight(15).Substring(0,15)
                   + txtAddSymbol.Text.ToUpper().PadRight(15).Substring(0,15)
                   + txtAddCompany.Text.PadRight(15).Substring(0,15)
                   + transactionType.PadRight(15).Substring(0,15)
                   + date.PadRight(15).Substring(0,15)
                   + sharePrice.ToString("c").PadRight(15).Substring(0,15)
                   + ofShares.ToString().PadRight(15).Substring(0,15)
                   + commissions.ToString("c").PadRight(15).Substring(0,15)
                   + totalAssetValue.ToString("c").PadRight(18).Substring(0,17)
                   + totalTransactionValue.ToString("c").PadRight(22).Substring(0,22)
                   + notes.Replace("\n", " ") +"\n";

            try
            {
                using (writer = new StreamWriter(fileName, append: true))
                {
                    writer.Write(record);
                    txtMessages.Text = "Transaction is recored";
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "[Exception] - Add StreamWriter: " + ex.Message; 
            }
            btnDisplay_Click(sender, e);
        }

        // This function displays where the user should focus based on the error message.
        private string ErrorFocus(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return message;
            }

            string[] errorArray = message.Split(new string[] { " " }, StringSplitOptions.None);

            if (errorArray.Contains("ID"))
            {
                txtAddId.SelectAll();
                txtAddId.Focus();
            }
            else if (errorArray.Contains("Symbol"))
            {
                txtAddSymbol.SelectAll();
                txtAddSymbol.Focus();
            }
            else if (errorArray.Contains("Company"))
            {
                txtAddCompany.SelectAll();
                txtAddCompany.Focus();
            }
            else if (errorArray.Contains("Type"))
            {
                rdoBuy.Focus();
            }
            else if (errorArray.Contains("Date"))
            {
                transactionDate.Focus();
            }
            else if (errorArray.Contains("Notes"))
            {
                txtAddNotes.SelectAll();
                txtAddNotes.Focus();
            }
            else if (errorArray.Contains("price"))
            {
                txtAddSharePrice.SelectAll();
                txtAddSharePrice.Focus();
            }
            else if (errorArray.Contains("shares"))
            {
                txtAddOfShares.SelectAll();
                txtAddOfShares.Focus();
            }
            else if (errorArray.Contains("Commission"))
            {
                txtAddCommission.SelectAll();
                txtAddCommission.Focus();
            }
            else if (errorArray.Contains("Delete"))
            {
                txtDeleteId.SelectAll();
                txtDeleteId.Focus();
            }
            return message;
        }

        // Displays the record.
        // It is automatically executed when there is a change in information.
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            txtData.Text = "";
            txtData.Text = "Transaction ID".PadRight(15).Substring(0,15)
                           + "TickerSymbol".PadRight(15).Substring(0,15)
                           + "Company".PadRight(15).Substring(0,15)
                           + "Type".PadRight(15).Substring(0,15)
                           + "Date".PadRight(15).Substring(0,15)
                           + "SharePrice".PadRight(15).Substring(0,15)
                           + "#Shares".PadRight(15).Substring(0,15)
                           + "Commission".PadRight(15).Substring(0,15)
                           + "TotalAssetValue".PadRight(18).Substring(0,17)
                           + "TotalTransactionValue".PadRight(22).Substring(0,22) + "\n";

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        txtData.Text += reader.ReadLine().Substring(0,159) + "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                txtData.Text = "[Exception] - Dispaly Stream Reader: " + ex.Message;
            }
        }

        // Initialize the data being input.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddId.Text = "";
            txtAddSymbol.Text = "";
            txtAddCompany.Text = "";
            rdoBuy.Checked = false;
            rdoSell.Checked = false;
            transactionDate.Value = DateTime.Today;
            txtAddNotes.Text = "";
            txtAddSharePrice.Text = "";
            txtAddOfShares.Text = "";
            txtAddCommission.Text = "";
            txtMessages.Text = "Clear";
        }

        // Data is removed based on the Transaction ID.
        // If there is no Transaction ID matching the data, an error message is displayed.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorMessage = "";
            transactionId = 0;
            if (string.IsNullOrWhiteSpace(txtDeleteId.Text))
            {
                errorMessage = "Delete number must be entered";
            }
            else if (!int.TryParse(txtDeleteId.Text, out transactionId))
            {
                errorMessage = "Delete number must be numeric";
            }
            else if (transactionId < 0)
            {
                errorMessage = "Delete number is greater than zero";
            }
            else if (DeleteFound(Convert.ToInt32(txtDeleteId.Text), fileName) != true)
            {
                errorMessage = "Delete number is not found";
            }

            txtMessages.Text = ErrorFocus(errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                return;
            }

            string tempFile;
            List<string> line = new List<string>();

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        tempFile = reader.ReadLine();
                        if (transactionId.ToString() != tempFile.Substring(0, 5).Trim())
                        {
                            line.Add(tempFile);
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                txtMessages.Text = "[Exception] - Delete StreamReader: " + ex.Message;
            }

            try
            {
                using (writer = new StreamWriter(fileName, append: false))
                {
                    foreach (var newRecord in line)
                    {
                        writer.WriteLine(newRecord);
                    }
                }
                txtMessages.Text = "The record of the selected Transaction ID has been deleted";

            }
            catch (Exception ex)
            {
                txtMessages.Text = "[Exception] - Delete StreamWriter: " + ex.Message;
            }
            btnDisplay_Click(sender, e);
        }

        // This is a function that helps delete data.
        private bool DeleteFound(int id, string recordPath)
        {
            bool found = false;
            string tempFile = "";
            try
            {
                using (reader = new StreamReader(recordPath))
                {
                    while (!reader.EndOfStream)
                    {
                        tempFile = reader.ReadLine();
                        if (id.ToString() == tempFile.Substring(0, 3).Trim())
                        {
                            found = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "[Exception] - Delete Found: " + ex.Message;
            }
            return found;
        }

        // Delete all data.
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            using (writer = new StreamWriter(fileName, append: false))
            {
                writer.Write("");
            }
            txtMessages.Text = "All records have been deleted";
            btnDisplay_Click(sender, e);
        }

        // Exit the program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
