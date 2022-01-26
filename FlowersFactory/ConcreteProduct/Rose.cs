using FlowersFactory.AbstractProduct;

namespace FlowersFactory.ConcreteProduct
{
    public class Rose : Flower
    {
        public int NumberOfSpikes { get; private set; }
        public Rose(int numberOfPetals, string color, int numberOfSpikes) : base("Rose", numberOfPetals, color)
        {
            NumberOfSpikes = numberOfSpikes;
        }

        public override void Grow()
        {
            NumberOfPetals++;
            NumberOfSpikes++;
            System.Console.WriteLine($"Growing {Color} {Name} with {NumberOfSpikes} spikes. Number of petals: {NumberOfPetals}.");
        }
    }
}
