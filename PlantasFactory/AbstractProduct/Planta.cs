namespace PlantasFactory.AbstractProduct
{
    public abstract class Planta
    {
        protected Planta(string nome, int numeroDePetalas, string cor)
        {
            Nome = nome;
            NumeroDePetalas = numeroDePetalas;
            Cor = cor;
        }

        public int NumeroDePetalas { get; set; }
        public string Cor { get; set; }
        public string Nome { get; set; }

        public void Crescer()
        {
            NumeroDePetalas++;
            System.Console.WriteLine($"Crescendo {Nome} {Cor}. Número de pétalas: {NumeroDePetalas}.");
        }
    }
}
