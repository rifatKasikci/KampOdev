using KampOdev.Abstract;
using KampOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev.Concreate
{
    public class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine(game.GameName + " Game added.");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.GameName + " Game deleted.");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.GameName + " Game updated.");
        }
    }
}
