using PlantasFactory.AbstractProduct;

namespace PlantasFactory.ConcreteProduct
{
    public class Rosa : Planta
    {
        public int NumeroDeEspinhos { get; set; }
        public Rosa(int numeroDePetalas, string cor, int numeroDeEspinhos) : base("Rosa", numeroDePetalas, cor)
        {
            NumeroDeEspinhos = numeroDeEspinhos;
        }
    }
}
