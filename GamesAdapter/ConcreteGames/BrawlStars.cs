using System;

namespace GamesAdapter.ConcreteGames
{
    public class BrawlStars : IGame
    {
        public void RunGame()
        {
            Console.WriteLine("Running Brawl Stars");
        }
        public void PauseGame()
        {
            Console.WriteLine("Pausing Brawl Stars");
        }

    }
}
