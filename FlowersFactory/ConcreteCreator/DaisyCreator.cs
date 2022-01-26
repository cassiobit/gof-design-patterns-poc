
using FlowersFactory.AbstractCreator;
using FlowersFactory.AbstractProduct;
using FlowersFactory.ConcreteProduct;

namespace FlowersFactory.ConcreteCreator
{
    public class DaisyCreator : FlowerCreator
    {
        private readonly int _numeroDePetalas;
        private readonly string _cor;

        public DaisyCreator(int numeroDePetalas, string cor)
        {
            _numeroDePetalas = numeroDePetalas;
            _cor = cor;
        }
        
        public override Flower CreateFlower()
        {
            return new Daisy(_numeroDePetalas, _cor);
        }
    }
}
