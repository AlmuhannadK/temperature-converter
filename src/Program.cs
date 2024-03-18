
Console.WriteLine("Enter a temperature and its unit (C or F):");


int temperature = int.Parse(Console.ReadLine());
Console.WriteLine(temperature);

class TemperatureConverter
{
    public string TempConvert(int temperature, string unit) 
    {
        if(unit.ToUpper() == "F") {
            float result = ((temperature - 32) * 5/9);
            return result + "C";
        } else {
            float result = (temperature * 9/5) + 32;
            return result + "F";
        }
    }

}
