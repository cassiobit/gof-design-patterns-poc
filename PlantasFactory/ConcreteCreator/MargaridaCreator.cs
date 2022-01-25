
using PlantasFactory.AbstractCreator;
using PlantasFactory.AbstractProduct;
using PlantasFactory.ConcreteProduct;

namespace PlantasFactory.ConcreteCreator
{
    public class MargaridaCreator : PlantaCreator
    {
        private readonly int _numeroDePetalas;
        private readonly string _cor;

        public MargaridaCreator(int numeroDePetalas, string cor)
        {
            _numeroDePetalas = numeroDePetalas;
            _cor = cor;
        }
        
        public override Planta CriarPlanta()
        {
            return new Margarida(_numeroDePetalas, _cor);
        }
    }
}
