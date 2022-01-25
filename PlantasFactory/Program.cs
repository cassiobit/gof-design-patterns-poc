using System;
using PlantasFactory.AbstractCreator;
using PlantasFactory.AbstractProduct;
using PlantasFactory.ConcreteCreator;

namespace PlantasFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PlantaCreator margaridaCreator = new MargaridaCreator(1, "azul");
            Planta margarida = margaridaCreator.CriarPlanta();
            margarida.Crescer();

            PlantaCreator rosaCreator = new RosaCreator(1, "azul",6);
            Planta rosa = rosaCreator.CriarPlanta();
            rosa.Crescer();

        }
    }
}
