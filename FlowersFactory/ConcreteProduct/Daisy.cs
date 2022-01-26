using FlowersFactory.AbstractProduct;

namespace FlowersFactory.ConcreteProduct
{
    public class Daisy : Flower
    {
        public Daisy(int numberOfPetals, string color) : base("Daisy", numberOfPetals, color)
        {
        }
    }
}
