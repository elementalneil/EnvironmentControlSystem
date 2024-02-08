using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPeopleCounterLib;

namespace PeopleCounterLib
{
    public class PeopleCountSensor : IPeopleCountSensor
    {
        public int GetPeopleCount()
        {
            // Simulated method to get people count
            Random rand = new Random();
            return rand.Next(1, 6); // Random number of people between 1 to 5
        }
    }
}
