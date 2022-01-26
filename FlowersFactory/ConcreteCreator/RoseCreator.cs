
using FlowersFactory.AbstractCreator;
using FlowersFactory.AbstractProduct;
using FlowersFactory.ConcreteProduct;

namespace FlowersFactory.ConcreteCreator
{
    public class RoseCreator : FlowerCreator
    {
        private readonly int _numberOfPetals;
        private readonly int _numberOfSpikes;
        private readonly string _color;

        public RoseCreator(int numberOfPetals, string color, int numberOfSpikes)
        {
            _numberOfPetals = numberOfPetals;
            _color = color;
            _numberOfSpikes = numberOfSpikes;
        }
        
        public override Flower CreateFlower()
        {
            return new Rose(_numberOfPetals, _color, _numberOfSpikes);
        }
    }
}
