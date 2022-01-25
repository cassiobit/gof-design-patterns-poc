using PlantasFactory.AbstractProduct;

namespace PlantasFactory.ConcreteProduct
{
    public class Margarida : Planta
    {
        public Margarida(int numeroDePetalas, string cor) : base("Margarida", numeroDePetalas, cor)
        {
        }
    }
}
