using JogosAdapter.JogosConcretos;

namespace JogosAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoService brawl = new JogoService(new BrawlStars());
            brawl.Jogar();

            System.Console.WriteLine("\n--------------\n");
            
            JogoService fruitNinja = new JogoService(new FruitNinjaAdapter(new FruitNinja()));
            fruitNinja.Jogar();
        }
    }
}
