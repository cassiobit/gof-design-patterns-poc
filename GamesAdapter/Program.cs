using GamesAdapter.ConcreteGames;

namespace GamesAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            GameService brawlStars = new GameService(new BrawlStars());
            brawlStars.Play();

            System.Console.WriteLine("\n--------------\n");
            
            GameService fruitNinja = new GameService(new FruitNinjaAdapter(new FruitNinja()));
            fruitNinja.Play();
        }
    }
}
