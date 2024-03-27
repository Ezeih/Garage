using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Boat : Vehicle
    {


        public Boat(string type, string make, string model, int year) : base(type, make, model, year)
        {
        }

        public uint NumberOfEngines { get; set; }



    }
}