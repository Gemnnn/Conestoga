using Microsoft.AspNetCore.Mvc;
using PressYourLuck.Helpers;
using PressYourLuck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            ViewData["currentBet"] = CoinsHelper.GetCurrentBet(HttpContext);
            ViewData["TotalCoin"] = CoinsHelper.GetTotalCoins(HttpContext);


            var tileList = new List<Tile>();

            if (GameHelper.GetCurrentGame(HttpContext) == null)
            {
                tileList = GameHelper.GenerateNewGame();
                Game game = new Game();

                game.Tiles = tileList;
                string jsonGame = GameHelper.SerializeTileList(HttpContext, game);
                GameHelper.SaveCurrentGame(HttpContext, jsonGame);
            }
            else
            {
                tileList = GameHelper.GetCurrentGame(HttpContext);
            }
            return View(tileList);
        }

        public IActionResult Reveal(int index)
        {
            double totalCoins = CoinsHelper.GetTotalCoins(HttpContext);
            var bet = GameHelper.PickTileAndUpdateGame(HttpContext, index);
            
            if (bet == 0)
            {
                TempData["ZeroTile"] = "Oh no! You busted out. Better luck next time!";
            }
            else if (totalCoins == 0)
            {
                TempData["ZeroTotal"] = "You've lost all your coins and must enter more to keep playing.";
            }
            else if (bet != 0)
            {
                TempData["NonZeroTile"] = "Congrats! you've found a " + bet + " multipler!" +
                    " All remaining valuew have doubled. Will you Press Your Luck?";
            }
            CoinsHelper.SaveCurrentBet(HttpContext, bet);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddCoins()
        {
            double currentBet = CoinsHelper.GetCurrentBet(HttpContext);
            double totalCoins = CoinsHelper.GetTotalCoins(HttpContext);

            totalCoins += currentBet;
            CoinsHelper.SaveTotalCoins(HttpContext, totalCoins);
            TempData["TakeCoin"] = "BIG WINNER! You chased out for " + currentBet + " coins! " +
                "Care to press your luck agian?";

            return RedirectToAction("Index", "Home");
        }
    }
}
