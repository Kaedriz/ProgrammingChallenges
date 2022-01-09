namespace ProgrammingChallenges;

public interface IChallange
{
    string Name();
    void Start();
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Hi!");
        Console.WriteLine("This is a program which aggregates all the other mini programs that I wrote for ProgrammingChallanges.");
        Console.WriteLine("Here are the ones that I did already:");
        Console.WriteLine();
        Console.WriteLine(" 01. Guess The Number");
        Console.WriteLine();
        Console.WriteLine("Type number to select mini program.");
        Console.Write("Number: ");
        string? input = Console.ReadLine();

        switch(int.Parse(input))
        {
            case 1:
                // Odpal
                var Program = new GuessTheNumber();
                Program.Start();
                break;
            default:
                Console.WriteLine("Brak programu o takim numerze.");
                break;
        }
    }
}