using GamesAdapter.ConcreteGames;

namespace GamesAdapter
{
    internal class FruitNinjaAdapter : IGame
    {
        private readonly FruitNinja _fruitNinja;

        public FruitNinjaAdapter(FruitNinja fruitNinja)
        {
            this._fruitNinja = fruitNinja;
        }

        public void RunGame()
        {
            _fruitNinja.ExecuteGame();
        }

        public void PauseGame()
        {
            _fruitNinja.InterruptGame();
        }
    }
}