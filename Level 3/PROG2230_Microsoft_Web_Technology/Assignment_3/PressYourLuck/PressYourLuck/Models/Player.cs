using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class Player
    {
        [Required(ErrorMessage = "Name must be required")]
        public string PlayerName { get; set; }

        [Required(ErrorMessage = "Totalcoin must be required")]
        [Range(1.00, 10000.00, ErrorMessage = "Amount of coins between 1 - 10000")]
        public double TotalCoins { get; set; }
    }
}
