using FlowersFactory.AbstractCreator;
using FlowersFactory.AbstractProduct;
using FlowersFactory.ConcreteCreator;

namespace FlowersFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerCreator daisyFlowerCreator = new DaisyCreator(1, "blue");
            Flower daisy = daisyFlowerCreator.CreateFlower();
            daisy.Grow();

            FlowerCreator roseFlowerCreator = new RoseCreator(1, "red", 6);
            Flower rose = roseFlowerCreator.CreateFlower();
            rose.Grow();

        }
    }
}
