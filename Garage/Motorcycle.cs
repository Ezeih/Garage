using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string type, string make, string model, int year) : base(type, make, model, year)
        {
        }

        public int NumberOfEngines { get; set; }
        public int CylinderVolume { get; set; }
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public double Length { get; set; }
    }
}
