
using System;

namespace RDA.AutoRepair.BL
{
    public abstract class Vehicle : IStartable, IComparable<Vehicle>
    {
        public int ID { get; set; }

        public string VIN { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
        public bool NeedsKey { get; set; }

        public int CompareTo(Vehicle other)
        {
            return Make.CompareTo(other.Make);
        }

        public void Start()
        {
            throw new Exception("Why did you call Start()???");
        }

        // protected method example
        protected void UpdateVIN(string vin)
        {
            VIN = vin;
        }
    }
}
