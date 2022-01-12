namespace ProgrammingChallenges;

class GuessTheNumber: IChallange
{
    public string Name() => "Guess The Number";
    private bool guessed = false;
    private static int Random()
    {
        // Generating random number
        Random Random = new Random();
        return Random.Next(1, 101);
    }
    private static int InputNumber()
    {
        // Checking if input is parsable, if it is return number
        string? input = Console.ReadLine();
        int guessNumber;
        while (!int.TryParse(input, out guessNumber))
        {
            Console.WriteLine("You didn't type number in correct format. Please try again using only digits.");
            input = Console.ReadLine();
        }
        return guessNumber;
    }
    public void Start()
    {
        Console.WriteLine("I'm gonna generate random number from 1 to 100.");
        Console.WriteLine("Try to guess what that number might be. Don't worry, I will help you.");
        Console.WriteLine("Now, try guessing!");
        int randomNumber = Random();
        while (!guessed)
        {
            int guessNumber = InputNumber();

            // Checking if guess number is in range
            if (guessNumber < 1 || guessNumber > 100)
            {
                Console.WriteLine("Number should be in range from 1 to 100 inclusive.");
                Console.WriteLine("Please try again.");
                continue;
            }
            Console.WriteLine($"You typed {guessNumber}. Let's check if that is the correct number.");

            if (guessNumber == randomNumber)
            {
                guessed = true;
                Console.WriteLine("Congratulations! You guessed it right.");
            }
            else if (guessNumber < randomNumber)
            {
                if (guessNumber < randomNumber - 10) Console.WriteLine("Too small. Try again with smaller number.");
                else Console.WriteLine("A bit to small. Try again with smaller number.");
            }
            else
            {
                if (guessNumber > randomNumber + 10) Console.WriteLine("Too large. Try again with smaller number.");
                else Console.WriteLine("A bit to large. Try again with smaller number.");

            }
        }
        Console.WriteLine("Now, if you want to try again, restart this aplication.");
    }
}
