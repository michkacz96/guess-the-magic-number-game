namespace NumberGame
{
    public class Player
    {
        private int _bestScore = int.MaxValue;
        public string Name { get; set; }
        public int BestScore
        {
            get
            {
                return _bestScore;
            }
            private set
            {
                if(value < _bestScore)
                {
                    _bestScore = value;
                }
            }
        }
        public Player(string name)
        {
            Name = name;
        }

        public void Play()
        {
            Game game = new Game();
            game.Play();
            BestScore = game.Tries;
            game.Results();
        }
    }
}
