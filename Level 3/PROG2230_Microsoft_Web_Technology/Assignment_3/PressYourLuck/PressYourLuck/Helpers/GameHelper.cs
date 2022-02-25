using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PressYourLuck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Helpers
{
    public static class GameHelper
    {
        //This creates a collection of 12 tiles with randomly generated values
        public static List<Tile> GenerateNewGame()
        {
            var tileList = new List<Tile>();
            Random r = new Random();
            for (int i = 0; i < 12; i++)
            {
                double randomValue = 0;
                if (r.Next(1, 4) != 1)
                {
                    randomValue = (r.NextDouble() + 0.5) * 2;
                }

                var tile = new Tile()
                {
                    TileIndex = i,
                    Visible = false,
                    Value = randomValue.ToString("N2")
                };

                tileList.Add(tile);
            }
            return tileList;
        }

        /*
        * There are MANY other helpers you may want to create here.  I've created some
        *  placeholder as well as hints for others you may find useful:
        *
        * 
        * HINT: Remember that your HttpContext is not available in this class so you may
        * need to pass it into methods that need it!
        * 
        */


        // - GetCurrentGame - If there is no current game state in session Generate a New Game
        // and store it in session, otherwise deserialize the List<Tile> from session
        public static List<Tile> GetCurrentGame(HttpContext httpContext)
        {
            if (httpContext.Session.GetString("game") == null)
            {
                return null;
            }

            Game game = JsonConvert.DeserializeObject<Game>(httpContext.Session.GetString("game"));
            var results = new List<Tile>();
            results = game.Tiles;

            return results;
        }

        // - SaveCurrentGame - Save the current state of the game to session. 
        public static void SaveCurrentGame(HttpContext httpContext, string jsonGame)
        {
            httpContext.Session.SetString("game", jsonGame);
        }

        /* - PickATileAndUpdateGame - code that contains the game logic as 
         * mentioned in Part 4 of the assignment. Hint: you'll need to pass in the
         * id of the selected tile as one of the parameters.
         */
        public static double PickTileAndUpdateGame(HttpContext httpContext, int index)
        {
            Game game = new Game();

            game.Tiles = GetCurrentGame(httpContext);

            List<Tile> tiles = new List<Tile>();
            
            tiles = game.Tiles;

            Tile tile = new Tile();
            tile = tiles[index];

            tile.Visible = true;

            if (double.Parse(tile.Value) == 0)
            {
                for (int i = 0; i < tiles.Count; i++)
                {
                    tiles[i].Visible = true; 
                }
                SaveCurrentGame(httpContext, SerializeTileList(httpContext, game));
                return 0;
            }
            else
            {
                double currentBet = CoinsHelper.GetCurrentBet(httpContext);
                currentBet *= double.Parse(tile.Value);

                for (int i = 0; i < tiles.Count; i++)
                {
                    if (tiles[i].Visible == false)
                    {
                        tiles[i].Value = (double.Parse(tiles[i].Value) * 2).ToString("N2");
                    }
                }
                SaveCurrentGame(httpContext, SerializeTileList(httpContext, game));
                return currentBet;
            }
            

        }

        // - ClearCurrentGame - clear the current game state from session
        public static void ClearCurrentGame(HttpContext httpContext)
        {
            httpContext.Session.Remove("game");
        }

        //- Finally, methods to serialize and deserialzie the Tile list.
        public static string SerializeTileList(HttpContext httpContext, Game game)
        {

            var result = "";
            result = JsonConvert.SerializeObject(game);

            return result;
        }

        public static List<Tile> DeserializeTileList(/* parameters? */)
        {
            var results = new List<Tile>();
            //code goes here
            return results;
        }
    }
}
