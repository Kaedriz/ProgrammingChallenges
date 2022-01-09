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
        // Iterating in array with programs
        Console.WriteLine();
        for (int i = 0; i < ChallangeList.Count(); i++)
        {
            if (i < 9)
            {
                Console.WriteLine($" 0{i + 1} - {ChallangeList[i].Name()}");
            }
            else
            {
                Console.WriteLine($" {i + 1} - {ChallangeList[i].Name()}");
            }
        }
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
        Console.Clear();
    }
}