using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROG2230_Byounguk_Min.Models
{
    public class CompanyModel
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Please enter a Company Name.")]
        public string CompanyName { get; set; }

        public string CompanyAddress { get; set; }

        [Required(ErrorMessage = "Please enter a Ticker Symbol.")]
        public string Ticker { get; set; }
    }
}
