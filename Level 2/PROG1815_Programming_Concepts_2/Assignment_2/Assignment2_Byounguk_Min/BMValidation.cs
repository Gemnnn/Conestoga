using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment2_Byounguk_Min
{
    public class BMValidation
    {
        // Changes the first letter of the letter to uppercase and the remaining letters to lowercase.
        public static string BMCapitalize(string text)
        {

            if (string.IsNullOrEmpty(text))
            {
                text = text.Trim();
                text = "";
                return text;
            }
            else if (text != null)
            {
                text = text.Trim();
                text = Regex.Replace(text, @"[\p{P}-[\.]]", "");
                string title = string.Join(" ", text.Split(' ').ToList().ConvertAll(letter => letter.Substring(0, 1).ToUpper() + letter.Substring(1).ToLower()));
                return title;
            }
            return text;
        }

        // Checking the value if it is null first.
        // Checking that the member code format is 4 letters and 5 numbers.
        // The order of letters and numbers can be in any order.
        public static bool BMMemberCodeValidation(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return false;
            }
            else if (Regex.IsMatch(code, @"^(?=.*[A-Z].*[A-Z].*[A-Z].*[A-Z].*)(?=.*\d.*\d.*\d.*\d.*\d.*)[A-Z0-9]{9,}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checking the phone number is in the correct format.
        // Even if there is no input value, it returns'True'.
        public static bool BMPhoneNumberValidation(string phoneNumber)
        {

            if (Regex.IsMatch(phoneNumber, @"^[0-9][0-9][0-9] [0-9][0-9][0-9] [0-9][0-9][0-9][0-9]$") ||
               (Regex.IsMatch(phoneNumber, @"^[0-9][0-9][0-9]\.[0-9][0-9][0-9]\.[0-9][0-9][0-9][0-9]$")))
            {
                return true;
            }
            else if (string.IsNullOrEmpty(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checking that the value of the postal code matches the format.
        // If correct, convert the text to uppercase and add space if there is no space in the middle.
        public static bool BMUKPostalValidation(ref string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                code = "";
                return true;
            }
            else if (Regex.IsMatch(code, @"^[A-Za-z][A-Za-z]?[\d][A-Za-z\d]? [\d][A-Za-z][A-Za-z]$") ||
                    Regex.IsMatch(code, @"^[A-Za-z][A-Za-z]?[\d][A-Za-z\d]?[\d][A-Za-z][A-Za-z]$"))
            {

                if (Regex.IsMatch(code, @"^[A-Za-z][A-Za-z]?[\d][A-Za-z\d]?[\d][A-Za-z][A-Za-z]$"))
                {
                    code = code.ToUpper();
                    code = code.Replace(" ", "");

                    code = code.Substring(0, code.Length - 3) + " " + code.Substring(code.Length-3);
                    return true;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
