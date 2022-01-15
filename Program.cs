namespace ProgrammingChallenges;

public interface IChallange
{
    string Name();
    void Start();
}

class Program
{
    static private List<IChallange> ChallangeList = new List<IChallange>()
    {
        new GuessTheNumber(),
        new HeadsTails(),
        new TemperatureConverter()
    };
    static void Main()
    {
        Console.WriteLine("Hi!");
        Console.WriteLine("This is a program which aggregates all the other mini programs that I wrote for ProgrammingChallanges.");
        Console.WriteLine("Here are the ones that I did already:");
        // Iterating in array with programs
        Console.WriteLine();
        for (int i = 0; i < ChallangeList.Count(); i++)
        {
            // Add leading 0 if number is lesser that 10, ex. 5 to 05
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

        // Redo to calling challenge from list
        // or give error when there isn't any
        int inputNumber;
        while (!int.TryParse(input, out inputNumber))
        {
            Console.WriteLine("You didn't type number in correct format. Please try again using only digits.");
            input = Console.ReadLine();
        }
        Console.Clear();
        ChallangeList[inputNumber - 1].Start();
    }
}