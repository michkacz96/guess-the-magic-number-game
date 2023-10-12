namespace NumberGame
{
    public class Tournament
    {
        public int NumberOfPlayers;
        public int NumberOfGames;
        public List<Player> Players { get; set;} = new List<Player>();

        public Tournament()
        {
            NumberOfPlayers = 1;
        }
        public Tournament(int numberOfPlayers)
        {
            NumberOfPlayers = numberOfPlayers;
            NumberOfGames = 1;
        }

        public void AddPlayers()
        {
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                Console.Write("Player\'s name: ");
                string name = Console.ReadLine();
                Player player = new Player(name);
                Players.Add(player);
            }
        }

        public void BeginTournament()
        {
            for(int i = 0; i < NumberOfGames; i++)
            {
                Console.WriteLine("Round: {0}\n", i+1);
                foreach(Player player in Players)
                {
                    Console.WriteLine("Player: {0}\n", player.Name);
                    player.Play();

                    Console.Write("Continue...");
                    var x = Console.ReadLine();
                }
            }
        }

        public void EndTournament()
        {
            //objListOrder.OrderBy(o=>o.OrderDate).ToList();
            List<Player> sortedPlayers = Players.OrderBy(p => p.BestScore).ToList();

            Console.Clear();

            foreach(Player player in sortedPlayers)
            {
                Console.WriteLine("{0} : {1}", player.Name, player.BestScore);
            }
        }
    }
}
