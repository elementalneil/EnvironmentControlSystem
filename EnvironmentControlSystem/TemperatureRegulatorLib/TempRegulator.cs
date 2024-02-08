using System;
using ITemperatureRegulatorLib;

namespace TemperatureRegulatorLib
{
    public class TempRegulator : ITempRegulator
    {
        public void RegulateTemperature(int newTemperature)
        {
            Console.WriteLine($"Regulating temperature to {newTemperature} Celsius");
            // Simulated method to regulate temperature
        }
    }
}

