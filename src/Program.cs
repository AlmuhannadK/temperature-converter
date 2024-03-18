 class Program
{
    public static void Main(string[] args)
    {
        string TempConvert(int temperature, string unit) 
        {
            if(unit.ToUpper() == "F") {
                double result = ((temperature - 32) * 5/9);
                    return (result + " C"); 
            } else {
                double result = ((temperature * 9/5) + 32);
                return (result + " F"); 
            }
        }

        string result = TempConvert(100, "c");
        Console.WriteLine(result);
    }
}
