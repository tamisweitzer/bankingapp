using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.AutoRepair.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void PopulateTestData()
        {
            Customer c;

            c = new Customer();
            c.FirstName = "Brian";
            c.LastName = "Foote";
            c.PhoneNumber = "920-555-1212";
            c.Cars.Add(new Car()
            {
                Make = "Toyota",
                Model = "Tundra",
                Year = 2010,
                VIN = "A1234567890"
            });
            Add(c);

            c = new Customer();
            c.FirstName = "Joe";
            c.LastName = "Wetzel";
            c.PhoneNumber = "920-555-3434";
            c.Cars.Add(new Car()
            {
                Make = "Jeep",
                Model = "Wrangler",
                Year = 2006,
                VIN = "B1234567890"
            });
            Add(c);
            
            c = new Customer();
            c.FirstName = "Ryan";
            c.LastName = "Appel";
            c.PhoneNumber = "920-555-5656";
            c.Cars.Add(new Car()
            {
                Make = "Mitsubishi",
                Model = "Eclipse",
                Year = 2007,
                VIN = "C1234567890"
            });
            c.Cars.Add(new Car()
            {
                Make = "McLaren",
                Model = "P1",
                Year = 2018,
                VIN = "D1234567890"
            });
            Add(c);
        }
    }
}
