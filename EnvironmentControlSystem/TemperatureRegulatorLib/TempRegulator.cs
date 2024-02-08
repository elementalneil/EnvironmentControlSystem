using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

