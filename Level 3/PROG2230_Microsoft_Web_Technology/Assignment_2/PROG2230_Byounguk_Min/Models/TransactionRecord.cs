using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROG2230_Byounguk_Min.Models
{
    public class TransactionRecord
    {
        [Key]
        public int TransactionRecordId { get; set; }

        [Required(ErrorMessage = "Please Enter a Quantity.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integar number greater than 0")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Please enter a Share Pirce.")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid double number greater than 0.00")]
        public double? SharePrice { get; set; }

        //[ForeignKey("TransactionType")]
        [Required(ErrorMessage = "Please select a transaction type.")]
        public int TransactionTypeId { get; set; }

        public TransactionType TransactionType { get; set; }

        //[ForeignKey("CompanyModel")]
        [Required(ErrorMessage = "Please select a company.")]
        [ForeignKey("CompanyModel")]
        public int CompanyId { get; set; }

        public CompanyModel CompanyModel { get; set; }


        /// <summary>
        /// Take Queantity and Shareprice values and calculate Grossvalue.
        /// </summary>
        /// <param name="Quantity">Number of shares</param>
        /// <param name="SharePrice">Price per share</param>
        /// <returns></returns>
        public double CalculateGrossValue()
        {
            int? quantity = Quantity;
            double? sharePrice = SharePrice;
            double GrossValue = (double)(quantity * sharePrice);
            return Convert.ToDouble(GrossValue);
        }

        /// <summary>
        /// Take the quantity and stock price, calculate the total value,
        /// and add up the commission fee to calculate the Netvalue.
        /// </summary>
        /// <param name="Quantity">Number of shares</param>
        /// <param name="SharePrice">Price per share</param>
        /// <param name="Comission">Stock trading fee</param>
        /// <returns></returns>
        public double CalculateNetValue()
        {
            int? quantity = Quantity;
            double? sharePrice = SharePrice;
            double GrossValue = (double)(quantity * sharePrice);
            double NetValue = ((double)(GrossValue + TransactionType.Commission));
            return Convert.ToDouble(NetValue);
        }

    }
}
