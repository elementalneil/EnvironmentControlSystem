using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureCalculatorLib
{
    public class TempCalculator : ITempCalculator
    {
        public int CalculateNewTemperature(int peopleCount, int outsideTemp)
        {
            // Simplified logic for temperature calculation
            return outsideTemp - (peopleCount * 2); // Decrease 2 degrees Celsius for each person in the car
        }
    }
}
