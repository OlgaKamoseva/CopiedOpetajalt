using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt
{
    public class Train : Vehicle
    {
        public int Carriages { get; set; }
        public decimal TrackWidth { get; set; }
        public bool hasCatering { get; set;  }
        public Train(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }
        public override string GetInfo()
            // Klassi Train meetod GetInfo asendab baasklassist tulevat meetodit, kaitstud sona override abil, kuna baasklassis oleval meetodil on juures kaitstud sona virtual
        {
            return $"This is a {Mark} {Model}, it is {Colour} color and has {Carriages} Tons.\nIt runs on a track with the width: {TrackWidth}";
        }
    }
}
