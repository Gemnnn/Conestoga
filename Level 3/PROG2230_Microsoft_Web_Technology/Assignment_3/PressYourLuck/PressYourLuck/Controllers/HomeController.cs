/*
 * Program ID : Assignment 3
 *
 * Press Your Luck
 *
 * Revision History : Created by Byounguk Min Nov 9, 2021
 */


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PressYourLuck.Helpers;
using PressYourLuck.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (Request.Cookies["playerName"] == null)
            {
                return RedirectToAction("Index", "Player");
            }
            ViewData["userName"] = Request.Cookies["playerName"];
            ViewData["TotalCoin"] = CoinsHelper.GetTotalCoins(HttpContext);

            return View();
        }

        [HttpPost]
        public IActionResult Index(Bet bet)
        {
            if (ModelState.IsValid)
            {
                double totalCoins = CoinsHelper.GetTotalCoins(HttpContext);
                totalCoins -= bet.CurrentBet;
                CoinsHelper.SaveTotalCoins(HttpContext, totalCoins);
                CoinsHelper.SaveCurrentBet(HttpContext, bet.CurrentBet);
                GameHelper.ClearCurrentGame(HttpContext);
                return RedirectToAction("Index", "Game");
            }

            return View(bet);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CashOut()
        {
            Response.Cookies.Delete("playerName");
            Response.Cookies.Delete("totalCoins");
            return RedirectToAction("Index", "Player");
        }
    }
}
