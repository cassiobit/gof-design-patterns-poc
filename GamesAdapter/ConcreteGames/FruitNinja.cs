using System;

namespace GamesAdapter.ConcreteGames
{
    public class FruitNinja : IIOsGame
    {
        public void ExecuteGame()
        {
            Console.WriteLine("Executing Fruit Ninja");
        }

        public void InterruptGame()
        {
            Console.WriteLine("Interrupting Fruit Ninja");
        }
    }
}
