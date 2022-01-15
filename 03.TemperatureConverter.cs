namespace ProgrammingChallenges;
enum TemperatureTypes
{
    Kelvin,
    Celsius,
    Fahrenheit,
    Rankine
}
class TemperatureConverter : IChallange
{
    public string Name() => "Temperature Converter";
    private static double Convert(double value, TemperatureTypes from, TemperatureTypes to)
    {
        double valueInKelvin;

        // First converting input to Kelvin
        if (from == TemperatureTypes.Celsius)
        {
            valueInKelvin = value + 273.15;
        }
        else if (from == TemperatureTypes.Fahrenheit)
        {
            valueInKelvin = (value + 459.67) * (5/9);
        }
        else if (from == TemperatureTypes.Rankine)
        {
            valueInKelvin = value * ((double)5/9);
        }
        else
        {
            valueInKelvin = value;
        }

        // Then converting from Kelvin to others
        if (to == TemperatureTypes.Celsius)
        {
            return valueInKelvin - 273.15;
        }
        else if (to == TemperatureTypes.Fahrenheit)
        {
            return valueInKelvin * 1.8 - 459.67;
        }
        else if(to == TemperatureTypes.Rankine)
        {
            return valueInKelvin * 1.8;
        }
        else
        {
            return valueInKelvin;
        }
    }
    private bool InputParsable(string? input)
    {
        if(input == null) return false;
        string strippedInput = input.Trim();

        if (strippedInput == "1") return true;
        else if (strippedInput == "2") return true;
        else if (strippedInput == "3") return true;
        else if (strippedInput == "4") return true;
        else return false;
    }
    private TemperatureTypes InputParse(string input)
    {
        if (input == "1") return TemperatureTypes.Kelvin;
        else if (input == "2") return TemperatureTypes.Celsius;
        else if (input == "3") return TemperatureTypes.Fahrenheit;
        else return TemperatureTypes.Rankine;
    }
    public void Start()
    {
        Console.WriteLine("This program will convert temperature for you.");
        Console.WriteLine("These are selectable temperatures scales.");
        Console.WriteLine(" 1. Kelvin");
        Console.WriteLine(" 2. Celsius");
        Console.WriteLine(" 3. Fahrenheit");
        Console.WriteLine(" 4. Rankine");

        // Make a while loop until user writes good input
        TemperatureTypes inputFrom = TemperatureTypes.Kelvin;
        TemperatureTypes inputTo = TemperatureTypes.Kelvin;
        double inputValue = 0;

        string? input;
        bool isInputParsable = false;

        while(!isInputParsable)
        {
            Console.Write("From: ");
            input = Console.ReadLine();
            if (InputParsable(input))
            {
                isInputParsable = true;
                inputFrom = InputParse(input);
            }
            else Console.WriteLine("Wrong format. Write only number corresponding to temperature.");
        }
        // Reseting
        isInputParsable = false;

        while (!isInputParsable)
        {
            Console.Write("To: ");
            input = Console.ReadLine();
            if (InputParsable(input))
            {
                isInputParsable = true;
                inputTo = InputParse(input);
            }
            else Console.WriteLine("Wrong format. Write only number corresponding to temperature.");
        }
        // Reseting
        isInputParsable = false;

        while (!isInputParsable)
        {
            Console.Write("Temperature value to convert: ");
            input = Console.ReadLine().Trim();
            // Checking if input is of type double, and then setting its value to 'inputValue'
            Console.WriteLine(inputValue);
            if (double.TryParse(input, out inputValue))
            {
                Console.WriteLine(inputValue);
                isInputParsable = true;
            }
            else
            {
                Console.WriteLine("Wrong format. Write only letter and eventualy dot.");
            }
        }
        double convertedValue = Convert(inputValue, inputFrom, inputTo);
        Console.WriteLine(inputValue);
        Console.WriteLine($"After converting {Math.Round(inputValue, 2)} ({inputFrom}) is {Math.Round(convertedValue, 2)} ({inputTo})");
    }
}
