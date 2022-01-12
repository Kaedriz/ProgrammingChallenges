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
    private static float Convert(float value, TemperatureTypes from, TemperatureTypes to)
    {
        float valueInKelvin = value;

        // First converting input to Kelvin
        if (from == TemperatureTypes.Celsius)
        {
            valueInKelvin = value + (float)273.15;
        }
        else if (from == TemperatureTypes.Fahrenheit)
        {
            valueInKelvin = (value + (float)459.67) * (5/9);
        }
        else if (from == TemperatureTypes.Rankine)
        {
            valueInKelvin = value * (5/9);
        }

        // Then converting from Kelvin to others
        if (to == TemperatureTypes.Kelvin)
        {
            return valueInKelvin;
        }
        else if (to == TemperatureTypes.Celsius)
        {
            return valueInKelvin - (float)273.15;
        }
        else if (to == TemperatureTypes.Fahrenheit)
        {
            return valueInKelvin * (9/5) - (float)459.67;
        }
        else if (to == TemperatureTypes.Rankine)
        {
            return valueInKelvin * (9/5);
        }
    }
    private TemperatureTypes? InputParse(string input)
    {
        if (input == "1") return TemperatureTypes.Kelvin;
        else if (input == "2") return TemperatureTypes.Celsius;
        else if (input == "3") return TemperatureTypes.Fahrenheit;
        else if (input == "4") return TemperatureTypes.Rankine;
        else return null;
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
        TemperatureTypes inputFrom;
        TemperatureTypes inputTo;
        float inputValue;

        while()
        {
            Console.Write("From: ");
            string? input = Console.ReadLine();
            InputParse(input);

        }

        if (input != null)
        {
        }
        else
        {
            Console.WriteLine("Wrong format. Write only letter corresponding to temperature.");
        }

        Console.Write("To: ");
        input = Console.ReadLine();
        if (input != null)
        {
            InputParse(input);
        }
        else
        {
            Console.WriteLine("Wrong format. Write only letter corresponding to temperature.");
        }

        Console.Write("Temperature value to convert: ");
        input = Console.ReadLine();
        if (input != null)
        {

        }
        else
        {
            Console.WriteLine("Wrong format. Write only letter and eventualy dot.");
        }
    }
}
