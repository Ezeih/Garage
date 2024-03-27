using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Airplane : Vehicle
    {
        public Airplane(string type, string make, string model, int year) : base(type, make, model, year)
        {
        }

        public double Weight { get; set; }

    }
}

