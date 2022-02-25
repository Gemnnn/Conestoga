using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class Bet
    {
        [Required(ErrorMessage = "Please enter the bet")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount of bet must be greater than zero.")]
        public double CurrentBet { get; set; }
    }
}
