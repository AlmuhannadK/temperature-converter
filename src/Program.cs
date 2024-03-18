class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Enter a temperature and its unit (C or F):");

            string? input = Console.ReadLine();

            string[] inputArr = input.Split(" ");
            double temperature = double.Parse(inputArr[0]);
            string unit = inputArr[1];
            string output = TempConvert(temperature, unit);

            Console.WriteLine($"Converted: {input} = {output}");
        }

    }

    static string TempConvert(double temperature, string unit)
    {
        if (unit.ToUpper() == "F")
        {
            double result = ((temperature - 32) * 5 / 9);
            return (result + " C");
        }
        else
        {
            double result = ((temperature * 9 / 5) + 32);
            return (result + " F");
        }
    }
}
