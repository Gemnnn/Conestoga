using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PressYourLuck.Models;
using PressYourLuck.Helpers;

namespace PressYourLuck.Controllers
{
    public class PlayerController : Controller
    {

        public IActionResult index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult index(Player player)
        {
            if (ModelState.IsValid)
            {
                Response.Cookies.Append("playerName", player.PlayerName);
                CoinsHelper.SaveTotalCoins(HttpContext, player.TotalCoins);

                return RedirectToAction("Index", "Home");

            }
            else
            {
                double totalCoins = CoinsHelper.GetTotalCoins(HttpContext);
                TempData["CashOut"] = "You cashed out for " + totalCoins + " coins";
            }


            return View(player);
        }
    }
}
