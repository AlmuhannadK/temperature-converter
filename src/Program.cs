class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a temperature and its unit (C or F) or type \"Quit\" to exit: ");
            string? input = Console.ReadLine();
            if (input is null || input.ToLower() == "quit")
            {
                break;
            }
            string[] inputArr = input.Split(" ");

            float temperature = 0;
            try
            {
                temperature = float.Parse(inputArr[0]);
            }

            catch (FormatException e)
            {
                Console.Write(e.Message);
                Console.WriteLine(" Please enter a numeric temperature.");
                continue;
            }

            string unit = inputArr[1];
            string output = "";

            if (unit.ToUpper() == "F" || unit.ToUpper() == "C")
            {
                output = TempConvert(temperature, unit);
            }
            else
            {
                Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
                continue;
            }

            Console.WriteLine($"Converted: {input} = {output}");
        }
    }

    static string TempConvert(float temperature, string unit)
    {
        if (unit.ToUpper() == "F")
        {
            float result = ((temperature - 32) * 5 / 9);
            return (result + " C");
        }
        else
        {
            float result = ((temperature * 9 / 5) + 32);
            return (result + " F");
        }
    }
}