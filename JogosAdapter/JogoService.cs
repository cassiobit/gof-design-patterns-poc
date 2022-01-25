namespace JogosAdapter
{
    class JogoService
    {
        private readonly Jogo _jogo;

        public JogoService(Jogo jogo)
        {
            _jogo = jogo;
        }

        public void Jogar(){
            _jogo.RodarJogo();
            _jogo.PausarJogo();
        }
    }
}
