using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }

        public bool Park(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }
            return false; // Garage full
        }

        public bool Retrieve(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == vehicle)
                {
                    vehicles[i] = null;
                    return true;
                }
            }
            return false; // Vehicle not found
        }

        public T FindVehicle(string registrationNumber)
        {
            return vehicles.FirstOrDefault(v => v?.RegistrationNumber.Equals(registrationNumber, StringComparison.OrdinalIgnoreCase) ?? false);
        }

        public IEnumerable<T> Search(Func<T, bool> predicate)
        {
            return vehicles.Where(predicate);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    yield return vehicle;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
