using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideTemp
{
    public class OutsideTempSensor : IOutsideTempSensor
    {
        public int GetOutsideTemp()
        {
            // Simulated method to get outside temperature
            Random rand = new Random();
            return rand.Next(0, 50); // Random temperature between 0 to 50 Celsius
        }
    }
}
