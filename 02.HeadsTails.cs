namespace ProgrammingChallenges;

class HeadsTails: IChallange
{
    public string Name() => "Heads Or Tails";
    private static int Random()
    {
        // Generating random number
        Random Random = new Random();
        return Random.Next(0, 2);
    }
    public void Start()
    {
        // Creating random number
        bool Heads = Convert.ToBoolean(Random());

        Console.WriteLine("Guess if this will be 'Heads' or 'Tails'.");
        Console.Write("Your guess: ");
        string? input = Console.ReadLine();
        switch(input)
        {
            case "Heads":
                if(Heads)
                {
                    Console.WriteLine("Congratulations! You guessed right.");
                } else
                {
                    Console.WriteLine("Sorry! You didn't guess right.");
                }
                break;
            case "Tails":
                if (Heads)
                {
                    Console.WriteLine("Sorry! You didn't guess right.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed right.");
                }
                break;
            default:
                Console.WriteLine("Incompatible answer!");
                break;
        }


    }
}
