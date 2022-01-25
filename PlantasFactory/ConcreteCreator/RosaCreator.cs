
using PlantasFactory.AbstractCreator;
using PlantasFactory.AbstractProduct;
using PlantasFactory.ConcreteProduct;

namespace PlantasFactory.ConcreteCreator
{
    public class RosaCreator : PlantaCreator
    {
        private readonly int _numeroDePetalas;
        private readonly int _numeroDeEspinhos;
        private readonly string _cor;

        public RosaCreator(int numeroDePetalas, string cor, int numeroDeEspinhos)
        {
            _numeroDePetalas = numeroDePetalas;
            _cor = cor;
            _numeroDeEspinhos = numeroDeEspinhos;
        }
        
        public override Planta CriarPlanta()
        {
            return new Rosa(_numeroDePetalas, _cor, _numeroDeEspinhos);
        }
    }
}
