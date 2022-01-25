using System;
using JogosAdapter.JogosConcretos;

namespace JogosAdapter
{
    internal class FruitNinjaAdapter : Jogo
    {
        private readonly FruitNinja _fruitNinja;

        public FruitNinjaAdapter(FruitNinja fruitNinja)
        {
            this._fruitNinja = fruitNinja;
        }

        public void RodarJogo()
        {
            _fruitNinja.ExecutarJogo();
        }

        public void PausarJogo()
        {
            _fruitNinja.InterromperJogo();
        }
    }
}