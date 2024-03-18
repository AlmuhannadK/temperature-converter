class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            // - Implement comprehensive error handling for invalid inputs (non-numeric values, unsupported scales).
            Console.WriteLine("Enter a temperature and its unit (C or F) or type \"Quit\" to exit: ");
            string? input = Console.ReadLine();
            if (input.toLower() == "quit" || input == "")
            {
                break;
            }

            string[] inputArr = input.Split(" ");
            double temperature = 0;
            try
            {
                temperature = double.Parse(inputArr[0]);
            }
            catch (Exception e)
            {
                // throw new ArgumentException("Please enter the right format for temperature");
                Console.WriteLine("Invalid input. Please enter a numeric temperature.");
                continue;
            }
            // using if else to check whether the number could be is number or not , if not, throw error and break; 
            string unit = unit = inputArr[1];

            // Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.
            string output = TempConvert(temperature, unit);

            Console.WriteLine($"Converted: {input} = {output}");

        }
    }

    static string TempConvert(double temperature, string unit)
    {
        if (unit.ToUpper() == "F")
        {
            double result = ((temperature - 32) * 5.0 / 9.0);
            return (result + " C");
        }
        if (unit.ToUpper() == "C")
        {
            double result = ((temperature * 9.0 / 5.0) + 32);
            return (result + " F");
        }
        else
        {
            Console.WriteLine("Please enter a valid scale.");
        }
    }
}
