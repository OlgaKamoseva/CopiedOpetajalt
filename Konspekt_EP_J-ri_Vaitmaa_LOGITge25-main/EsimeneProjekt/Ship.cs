using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt
{
    public class Ship : Vehicle
    {
        public int CrewCount { get; set; }
        public bool isCruiseOrCargo { get; set; }
        public int DisplacementVolume { get; set; }
        public Ship(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }
    }
}
