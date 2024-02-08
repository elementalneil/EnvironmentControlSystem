namespace TemperatureCalculatorLib
{
    public interface ITempCalculator
    {
        int CalculateNewTemperature(int peopleCount, int outsideTemp);
    }
}
