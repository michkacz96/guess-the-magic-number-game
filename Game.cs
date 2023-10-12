namespace NumberGame
{
    public class Game
    {
        private Random random = new Random();
        private readonly int toGuess;
        public int Tries { get; set; }
        public bool IsGuessed { get; private set; }

        public Game()
        {
            toGuess = random.Next(100);
            IsGuessed = false;
            Tries = 0;
        }

        public void Play()
        {
            Console.WriteLine("Guess the magic number!");

            while (!IsGuessed)
            {
                Console.Write("Enter your guess: ");
                int guess = 0;

                bool valInput = int.TryParse(Console.ReadLine(), out guess);

                if (valInput)
                {
                    if (guess == toGuess)
                    {
                        IsGuessed = true;
                    }
                    if (guess > toGuess)
                    {
                        Console.WriteLine("The magic number is lower then your guess");
                    }
                    if (guess < toGuess)
                    {
                        Console.WriteLine("The magic number is larger then your guess");
                    }

                    Tries++;
                }
                else
                {
                    Console.WriteLine("Try again. Guess the magic number");
                }

                
            }
        }

        public void Results()
        {
            Console.WriteLine("\nThe number was {0}", toGuess);
            if (Tries > 1)
            {
                Console.WriteLine("You win in {0} guesses:D", Tries);
            }
            else
            {
                Console.WriteLine("You win in {0} guess:D", Tries);
            }
        }
    }
}
