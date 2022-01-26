namespace GamesAdapter
{
    class GameService
    {
        private readonly IGame _jogo;

        public GameService(IGame jogo)
        {
            _jogo = jogo;
        }

        public void Play(){
            _jogo.RunGame();
            _jogo.PauseGame();
        }
    }
}
