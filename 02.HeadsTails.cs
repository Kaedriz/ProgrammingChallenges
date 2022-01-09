namespace ProgrammingChallenges;

class HeadsTails: IChallange
{
    private static int Random()
    {
        // Generating random number
        Random Random = new Random();
        return Random.Next(1, 101);
    }
    public void Start()
    {
        Console.WriteLine("");
    }
}
