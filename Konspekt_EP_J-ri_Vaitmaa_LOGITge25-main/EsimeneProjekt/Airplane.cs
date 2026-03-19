using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt
{
    public enum TravelClass
    {
        FirstClass, SecondClass, TouristClass, BaggageRoom
    }
    public class Airplane : Vehicle
    {
        public int FlyHeight { get; set; }
        public int LuggageRoom { get; set; }
        public Airplane(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }
    }
}
