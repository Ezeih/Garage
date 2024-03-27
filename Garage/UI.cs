using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class UI
    {
        private Garage<Vehicle> garage;
        private int numberOfWeels;

        public UI()
        {
            garage = null;
        }

        public void ShowMenu()
        {
            Console.WriteLine("1. Skapa ett garage");
            Console.WriteLine("2. Lista alla parkerade fordon");
            Console.WriteLine("3.Lista fordonstyper och antal");
            Console.WriteLine("4. Lägg till ett fordon i garaget");
            Console.WriteLine("5.Ta bort ett fordon från garaget");
            Console.WriteLine("6. Hitta ett fordon med registreringsnummer");
            Console.WriteLine("7. Stäng garage applikation");
        }

        public void CreateGarage(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            Console.WriteLine($"Garage med kapacitet {capacity} skapat framgångsrikt.");
        }

        public void ListAllVehicles()
        {
            if (garage == null)
            {
                Console.WriteLine("Garage har inte skapats ännu.");
                return;
            }

            foreach (var vehicle in garage)
            {
                Console.WriteLine($"Registreringsnummer: {vehicle.RegistrationNumber}, Färge: {vehicle.Color} , Antal hjul: {vehicle.NumberOfWheels}");
            }
        }

        public void ListVehicleTypesAndCounts()
        {
            if (garage == null)
            {
                Console.WriteLine("Garage har inte skapats ännu.");
                return;
            }

            var counts = garage.GroupBy(v => v.GetType().Name).Select(g => new { Type = g.Key, Count = g.Count() });

            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Type}: {count.Count}");
            }
        }

        public void AddVehicle(string registrationNumber, string type, string color)
        {
            if (garage == null)
            {
                Console.WriteLine("Garage har inte skapats ännu.");
                return;
            }

            Vehicle vehicle;
            switch (type.ToLower())
            {
                case "car":
                    vehicle = new Car { RegistrationNumber = registrationNumber, Color = color,  };
                    break;

                case "motorcycle":
                    vehicle = new Motorcycle { RegistrationNumber = registrationNumber, Color = color };
                    break;
                case "Airplane":
                    vehicle = new Airplane { RegistrationNumber = registrationNumber, Color = color };
                    break;
                default:
                    Console.WriteLine("Ogiltig fordonstyp.");
                    return;
            }

            if (garage.Park(vehicle))
            {
                Console.WriteLine("Fordonet har parkerats.");
            }
            else
            {
                Console.WriteLine("Det gick inte att parkera fordonet. Garaget är fullt.");
            }
        }

        public void RemoveVehicle(string registrationNumber)
        {
            if (garage == null)
            {
                Console.WriteLine("Garage har inte skapats ännu.");
                return;
            }

            var vehicle = garage.FindVehicle(registrationNumber);
            if (vehicle != null)
            {
                if (garage.Retrieve(vehicle))
                {
                    Console.WriteLine("Fordonet har tagits bort.");
                }
                else
                {
                    Console.WriteLine("Det gick inte att ta bort fordonet. försök igen.");
                }
            }
            else
            {
                Console.WriteLine("Fordonet hittades inte.");
            }
        }

        public void FindVehicleByRegistrationNumber(string registrationNumber)
        {
            if (garage == null)
            {
                Console.WriteLine("Garage har inte skapats ännu.");
                return;
            }

            var vehicle = garage.FindVehicle(registrationNumber);
            if (vehicle != null)
            {
                Console.WriteLine($"Fordon hittat - Typ : {vehicle.GetType().Name}, Färge: {vehicle.Color}");
            }
            else
            {
                Console.WriteLine("Fordonet hittades inte.");
            }
        }

        public void SearchForVehicles(Func<Vehicle, bool> predicate)
        {
            if (garage == null)
            {
                Console.WriteLine("Garage har inte skapats ännu.");
                return;
            }

            var results = garage.Search(predicate);
            foreach (var vehicle in results)
            {
                Console.WriteLine($"Type: {vehicle.GetType().Name}, Color: {vehicle.Color}");
            }
        }
    }
}
