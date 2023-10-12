namespace NumberGame
{
    class Program
    {
        static int numberOfPlayers; 
        static void Main(string[] args)
        {
            bool valNumPlayers = false;
            bool valNumGames = false;

            //Enter number of players
            do
            {
                Console.Write("Enter number of players: ");
                valNumPlayers = int.TryParse(Console.ReadLine(), out numberOfPlayers);
            } while (!valNumPlayers);
            

            //Begin tournament, add players
            Tournament tournament = new Tournament(numberOfPlayers);
            tournament.AddPlayers();

            //Enter number of turns for each player
            do
            {
                Console.Write("Enter number of games for a player: ");
                valNumGames = int.TryParse(Console.ReadLine(), out tournament.NumberOfGames);
            } while (!valNumGames);
            

            //Run game for all players
            tournament.BeginTournament();
            tournament.EndTournament();
        }
    }
}