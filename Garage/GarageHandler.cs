using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class GarageHandler 
    {

        private List<IVehicle> vehicles;

        

        public void AddVehicle(vehicles car1)
        {
            vehicles vehicle =  Vehicles();
            vehicles.Add((IVehicle)vehicle);
        }

        private vehicles Vehicles()
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(string label, string make, string model, int year)
        {
            // Sök efter fordonet med den angivna etiketten
            vehicles vehicle = (vehicles)vehicles.FirstOrDefault(v => v.Label == label);

            // Uppdatera fordonsinformation om den hittas
            if (vehicle != null)
            {
                vehicle.Make = make;
                vehicle.Model = model;
                vehicle.Year = year;
            }
        }

        public void RemoveVehicle(string label)
        {
            // Sök efter fordonet med den angivna etiketten
            Vehicle vehicle = (Vehicle)vehicles.FirstOrDefault(v => v.Label == label);

            // Radera fordonet om det hittas
            if (vehicle != null)
            {
                vehicles.Remove((IVehicle)vehicle);
            }
        }

        public void PrintVehicles()
        {
            foreach (vehicles vehicle in vehicles)
            {
                Console.WriteLine("Type: " + vehicle.Type +
                    ", Make: " + vehicle.Make +
                    ", Model: " + vehicle.Model +
                    ", Year: " + vehicle.Year);
            }
        }

     

        internal void UpdateVehicle()
        {
            throw new NotImplementedException();
        }

        internal void RemoveVehicle()
        {
            throw new NotImplementedException();
        }

        internal void AddVehicle(Vehicle car1)
        {
            throw new NotImplementedException();
        }
    }

    internal class vehicles
    {
        public vehicles(string make, string model, int year, string type)
        {
            Make = make;
            Model = model;
            Year = year;
            Type = type;
        }

        public string Make { get; internal set; }
        public string Model { get; internal set; }
        public int Year { get; internal set; }
        public string Type { get; internal set; }

      
    }

}


