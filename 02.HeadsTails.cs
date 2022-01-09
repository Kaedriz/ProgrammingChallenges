namespace ProgrammingChallenges;

class HeadsTails: IChallange
{
    public string Name()
    {
        return "Heads Or Tails";
    }
    private static int Random()
    {
        // Generating random number
        Random Random = new Random();
        return Random.Next(0, 2);
    }
    public void Start()
    {
        Console.WriteLine("");
    }
}
