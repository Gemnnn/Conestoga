using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PROG2230_Byounguk_Min.Models
{
    public class TransactionType
    {
        // These are the models used to represent the Transaction Type.
        // Some contain messages and requirements that appear when
        // the values entered by the user do not meet the requirements.

        [Key]
        public int TransactionTypeId { get; set; }

        [DisplayName("Trnasaction Type")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double? Commission { get; set; }
    }
}
