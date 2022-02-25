using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Assignment2_Byounguk_Min
{
    public partial class MinGymMemberManagement : Form
    {
        public MinGymMemberManagement()
        {
            InitializeComponent();
        }

        // Display temporary data
        private void btnPrefill_Click(object sender, EventArgs e)
        {
            txtName.Text = "Byounguk Min";
            txtGoal.Text = "To Run 126 mileS; in 2 hours.Perform 300 situps, and Squat 100 pOUNDS, by January of 2021.";
            txtHomePhone.Text = "000 000 0000";
            txtWorkPhone.Text = "000 000 0000";
            txtCellPhone.Text = "647 891 0841";
            txtEmail.Text = "bmin3561@conestogac.on.ca";
            txtDate.Text = "2021 Jan 20";
            txtMemberCode.Text = "ABC12345D";
            txtAddress.Text = "50 wellesely st e";
            txtTown.Text = "toronto";
            txtCountry.Text = "downtown";
            txtProvince.Text = "on";
            txtPostal.Text = "m4y0mm";
            lblMessage.Text = "Pre-fill has been replaced.";
        }

        // Each field is individually validated.
        // Data that can be modified is automatically corrected.
        // All error messages are displayed at once, but the focus is on the point where the first error occurred.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            string memberCode = txtMemberCode.Text.Trim();
            string homePhoneNumber = txtHomePhone.Text.Trim();
            string workPhoneNumber = txtWorkPhone.Text.Trim();
            string cellPhoneNumber = txtCellPhone.Text.Trim();
            string joinedDate = txtDate.Text.Trim();
            DateTime today = DateTime.Now;
            bool memberValue = BMValidation.BMMemberCodeValidation(memberCode);
            bool codeCheck;
            bool phoneNumberValue = true;
            bool workphoneNumberValue = true;
            bool cellphoneNumberValue = true;
            int i = 0;
            int checkNumber1 = 0;
            int checkNumber2 = 0;
            int checkNumber3 = 0;
            bool focusCheck0 = false;
            bool focusCheck1 = false;
            bool focusCheck2 = false;
            bool focusCheck3 = false;
            bool focusCheck4 = false;
            bool focusCheck5 = false;
            bool focusCheck6 = false;
            bool focusCheck7 = false;
            bool focusCheck8 = false;
            bool focusCheck9 = false;
            bool focusCheck10 = false;
            bool focusCheck11 = false;
            bool focusCheck12 = false;
            bool focusCheck13 = false;
            bool focusCheck14 = false;

            do
            {
                // [Full Name]
                txtName.Text = BMValidation.BMCapitalize(txtName.Text);
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    lblMessage.Text += "You must fill the your name.\n";
                    focusCheck0 = true;
                }


                // [Member Goal]
                txtGoal.Text = BMValidation.BMCapitalize(txtGoal.Text);
                if (string.IsNullOrEmpty(txtGoal.Text))
                {
                    lblMessage.Text += "You must fill the goal.\n";
                    focusCheck1 = true;
                }

                // [Home Phone]
                phoneNumberValue = BMValidation.BMPhoneNumberValidation(homePhoneNumber);
                if (phoneNumberValue == false)
                {
                    lblMessage.Text += "Home Phone Number is wrong.\n";
                    focusCheck2 = true;
                }
                else if (string.IsNullOrEmpty(txtHomePhone.Text))
                {
                    checkNumber1 = 0;
                }
                else
                {
                    checkNumber1 = 1;
                }

                // [Work Phone]
                workphoneNumberValue = BMValidation.BMPhoneNumberValidation(workPhoneNumber);
                if (workphoneNumberValue == false)
                {
                    lblMessage.Text += "Work Phone Number is wrong.\n";
                    focusCheck3 = true;
                }
                else if (string.IsNullOrEmpty(txtWorkPhone.Text))
                {
                    checkNumber2 = 0;
                }
                else
                {
                    checkNumber2 = 1;
                }
                
                // [Cell Phone]
                cellphoneNumberValue = BMValidation.BMPhoneNumberValidation(cellPhoneNumber);
                if (cellphoneNumberValue == false)
                {
                    lblMessage.Text += "Cell Phone Number is wrong.\n";
                    focusCheck4 = true;
                }
                else if (string.IsNullOrEmpty(txtCellPhone.Text))
                {
                    checkNumber3 = 0;
                }
                else
                {
                    checkNumber3 = 1;
                }

                NumberCheck(checkNumber1, checkNumber2, checkNumber3);
                if (NumberCheck(checkNumber1, checkNumber2, checkNumber3) == false)
                {
                    lblMessage.Text += "You must enter at least one number.\n";
                    focusCheck5 = true;
                }

                // [E-mail]
                if (IsValidEmail(txtEmail.Text) == true)
                {
                    txtEmail.Text = txtEmail.Text.ToLower();
                }
                else
                {
                    lblMessage.Text += "E-mail is wrong.\n";
                    focusCheck6 = true;
                }
                
                // [Date Joined]
                if (DateMatchCheck(joinedDate) != true)
                {
                    lblMessage.Text += "Date is wrong.\n";
                    focusCheck7 = true;
                }
                else
                {
                    var userDate = DateTime.Parse(joinedDate);

                    if (userDate > today)
                    {
                        lblMessage.Text += "Date can not be a future.\n";
                        focusCheck8 = true;
                    }
                }

                // [Member Code]
                if (memberValue == false)
                {
                    lblMessage.Text += "Membercode is wrong.\n";
                    focusCheck9 = true;
                }

                // [Mailing Address]
                string addressCheck = BMValidation.BMCapitalize(txtAddress.Text);
                if (addressCheck.Length < 3)
                {
                    lblMessage.Text += "Address must contain at least 3 letters.\n";
                    focusCheck10 = true;
                }
                else
                {
                    txtAddress.Text = addressCheck;
                }

                // [Town]
                string townCheck = BMValidation.BMCapitalize(txtTown.Text);
                if (townCheck.Length < 3)
                {
                    lblMessage.Text += "Town must contain at least 3 letters.\n";
                    focusCheck11 = true;
                }
                else
                {
                    txtTown.Text = townCheck;
                }

                // [Province Code]
                if (ProvinceCheck(txtProvince.Text) == false)
                {
                    lblMessage.Text += "Province must be exactly two letters.\n";
                    focusCheck12 = true;
                }
                else
                {
                    string provinceChange = txtProvince.Text.ToUpper();
                    txtProvince.Text = provinceChange;
                }

                //  [Postal Code]
                string postalCode = txtPostal.Text.Trim();
                codeCheck = BMValidation.BMUKPostalValidation(code: ref postalCode);
                if (string.IsNullOrEmpty(postalCode))
                {
                    lblMessage.Text += "Postalcode must be filled.\n";
                    focusCheck13 = true;
                }
                else if (codeCheck == true)
                {
                    txtPostal.Text = postalCode;
                }
                else
                {
                    lblMessage.Text += "Postalcode is worng.\n";
                    focusCheck14 = true;
                }

                // Focus to first field in error
                if (focusCheck0 == true)
                {
                    txtName.SelectAll();
                    txtName.Focus();
                    break;
                }
                else if (focusCheck1 == true)
                {
                    txtGoal.SelectAll();
                    txtGoal.Focus();
                    break;
                }
                else if (focusCheck2 == true)
                {
                    txtHomePhone.SelectAll();
                    txtHomePhone.Focus();
                    break;
                }
                else if (focusCheck3 == true)
                {
                    txtWorkPhone.SelectAll();
                    txtWorkPhone.Focus();
                    break;
                }
                else if (focusCheck4 == true)
                {
                    txtCellPhone.SelectAll();
                    txtCellPhone.Focus();
                    break;
                }
                else if (focusCheck5 == true)
                {
                    txtHomePhone.SelectAll();
                    txtHomePhone.Focus();
                    break;
                }
                else if (focusCheck6 == true)
                {
                    txtEmail.SelectAll();
                    txtEmail.Focus();
                    break;
                }
                else if (focusCheck7 == true)
                {
                    txtDate.SelectAll();
                    txtDate.Focus();
                    break;
                }
                else if (focusCheck8 == true)
                {
                    txtDate.SelectAll();
                    txtDate.Focus();
                    break;
                }
                else if (focusCheck9 == true)
                {
                    txtMemberCode.SelectAll();
                    txtMemberCode.Focus();
                    break;
                }
                else if (focusCheck10 == true)
                {
                    txtAddress.SelectAll();
                    txtAddress.Focus();
                    break;
                }
                else if (focusCheck11 == true)
                {
                    txtTown.SelectAll();
                    txtTown.Focus();
                    break;
                }
                else if (focusCheck12 == true)
                {
                    txtProvince.SelectAll();
                    txtProvince.Focus();
                    break;
                }
                else if (focusCheck13 == true)
                {
                    txtPostal.SelectAll();
                    txtPostal.Focus();
                    break;
                }
                else if (focusCheck14 == true)
                {
                    txtPostal.SelectAll();
                    txtPostal.Focus();
                    break;
                }
                else
                {
                    lblMessage.Text = "The Submit button has been executed.";
                }
                i = 12;
            } while (i < 11);
        }

        // Erase all text
        // And display 'All information has been cleaned' in the message box
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtGoal.Text = "";
            txtHomePhone.Text = "";
            txtWorkPhone.Text = "";
            txtCellPhone.Text = "";
            txtEmail.Text = "";
            txtDate.Text = "";
            txtMemberCode.Text = "";
            txtAddress.Text = "";
            txtTown.Text = "";
            txtCountry.Text = "";
            txtProvince.Text = "";
            txtPostal.Text = "";
            lblMessage.Text = "All information has been cleaned.";
        }

        // Close the program
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Separate values to change the case of the email
        private static bool IsValidEmail(string emailCheck)
        {
            try
            {
                if (string.IsNullOrEmpty(emailCheck))
                {
                    return true;
                }
                MailAddress mail = new MailAddress(emailCheck);
                return true;
            }
            
            catch (Exception)
            {
                return false;
            }
        }

        // Checking at least one phone number is recorded
        private static bool NumberCheck(int count1, int count2, int count3)
        {
            int totalCount = count1 + count2 + count3;
            if (totalCount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Classify and check functions transferred from Class
        private static bool DateMatchCheck(string date)
        {
            if (Regex.IsMatch(date, @"^[0-9]{4} [A-Z]{1}[a-z]{1}[a-z]{1} [0-9]{2}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checking thah Province is the correct number of characters
        private static bool ProvinceCheck(string province)
        {
            string provinceTrim = province.Trim(); 
            if (Regex.IsMatch(provinceTrim, @"^[A-Za-z]{1}[A-Za-z]{1}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
