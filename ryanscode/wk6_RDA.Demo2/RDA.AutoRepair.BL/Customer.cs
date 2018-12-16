using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.AutoRepair.BL
{
    public class Customer
    {
        // Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public List<Vehicle> Vehicles { get; set; }

        public string DisplayName
        {
            get { return LastName + ", " + FirstName; }
        }

        // Constructor
        public Customer()
        {
            Vehicles = new List<Vehicle>();
        }

        // Methods
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
