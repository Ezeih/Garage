using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Bus : Vehicle
    {
        public Bus(string type, string make, string model, int year) : base(type, make, model, year)
        {
        }

        public double Length { get; set; }
    }
}
