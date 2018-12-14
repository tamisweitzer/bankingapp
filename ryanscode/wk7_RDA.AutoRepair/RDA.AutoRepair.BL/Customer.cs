
using System.Collections.Generic;

namespace RDA.AutoRepair.BL
{
    public class Customer
    {
        // Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public List<Car> Cars { get; set; }

        public string DisplayName
        {
            get { return LastName + ", " + FirstName; }
        }

        // Constructor
        public Customer()
        {
            Cars = new List<Car>();
        }

        // Methods
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
