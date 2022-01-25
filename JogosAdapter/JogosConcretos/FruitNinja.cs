using System;

namespace JogosAdapter.JogosConcretos
{
    public class FruitNinja : JogoIOs
    {
        public void ExecutarJogo()
        {
            Console.WriteLine("Executando jogo");
        }

        public void InterromperJogo()
        {
            Console.WriteLine("Interrompendo jogo");
        }
    }
}
