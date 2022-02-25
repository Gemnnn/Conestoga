using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROG2230_AS1_BMin.Models
{
    // These are the models the program uses to represent data.
    // Some contain messages and requirements that appear
    // when the values entered by the user do not meet the requirements.
    public class TransactionRecord
    {
        public int TransactionRecordId { get; set; }

        [Required(ErrorMessage = "Please enter a Ticker Symbol.")]
        public string TickerSymbol { get; set; }

        [Required(ErrorMessage = "Please enter a Company Name.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter a Quantity")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number greater then 0")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please enter a Share Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid double Number greater then 0.00")]
        public double SharePrice { get; set; }

        [Required(ErrorMessage ="Please select a transaction type.")]
        public string TransactionTypeId { get; set; }
        public TransactionType TransactionType { get; set; }

        /// <summary>
        /// Takes Quantity and SharePrice values and calculates GrossValue.
        /// </summary>
        /// <param name="Quantity">number of shares</param>
        /// <param name="SharePrice">price per share</param>
        /// <returns></returns>
        public double CalculateGrossValue(double Quantity, double SharePrice)
        {
            double GrossValue = Quantity * SharePrice;
            return GrossValue;
        }

        /// <summary>
        /// Take the quantity and stock price, calculate the total value, 
        /// and add up the commission fee to calculate the NetValue.
        /// </summary>
        /// <param name="Quantity">number of shares</param>
        /// <param name="SharePrice">price per share</param>
        /// <param name="Commission">Stock Trading Fees</param>
        /// <returns></returns>
        public double CalculateNetValue(double Quantity, double SharePrice, double Commission)
        {
            double GrossValue = Quantity * SharePrice;
            double NetValue = GrossValue + Commission;
            return NetValue;
        }

    }
}
