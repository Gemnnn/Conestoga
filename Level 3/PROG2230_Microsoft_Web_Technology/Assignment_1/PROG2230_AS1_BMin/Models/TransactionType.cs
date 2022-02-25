using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROG2230_AS1_BMin.Models
{
    // These are the models used to represent the TransactionType.
    // Some contain messages and requirements that appear
    // when the values entered by the user do not meet the requirements.
    public class TransactionType
    {
        public string TransactionTypeId { get; set; }

        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Commission { get; set; }
    }
}
