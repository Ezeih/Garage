
using System.Collections.Generic;
using System;


namespace Garage
{
    // Fordonsklass
    public abstract class Vehicle : IVehicle
    {
        public enum VehicleType
        {
            Car,
            Motorcycle,
            Bus,
            Airplane,
            Boat
        }
        public string RegistrationID { get; set; }
        public string Color { get; set; }

        int NumberOfWheels { get; set; }
        public string Label { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected Vehicle(string type)
        {
        }

        public Vehicle(string type, string make, string model, int year) : this(type)
        {
        }

        protected Vehicle(string registrationID, string color, int numberOfWheels) : this(registrationID)
        {
            Color = color;

            NumberOfWheels = numberOfWheels;
        }

        protected Vehicle(string registrationID, string color, int numberOfWheels, string label) : this(registrationID, color, numberOfWheels)
        {
            Label = label;
        }

        public virtual void Initialize(string registration, string color, int numberOfWheels)
        {
            RegistrationID = registration;
            Color = color;

            NumberOfWheels = numberOfWheels;

        }
        public override string ToString()
        {
            return $"{GetType()}: {RegistrationID}, {Color}, {NumberOfWheels} ";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RegistrationID);
        }

        internal void addVehicle()
        {
            throw new NotImplementedException();
        }

        
    }


}

