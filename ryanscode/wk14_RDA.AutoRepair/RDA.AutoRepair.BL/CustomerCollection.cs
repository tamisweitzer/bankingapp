using RDA.AutoRepair.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.AutoRepair.BL
{
    public delegate void CustomerAdded();

    public class CustomerCollection : List<Customer>
    {
        public CustomerAdded OnCustomerAdded { get; set; }

        public CustomerCollection()
        {
            DataAccess.ConnectionString = "Server=tcp:appeldb.database.windows.net,1433;Initial Catalog=fvtc;Persist Security Info=False;User ID=ryan;Password=P@$$word;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

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

        public void LoadFromDB()
        {
            string sql = "select * from autoCustomers";
            DataTable data = DataAccess.Select(sql);
            foreach (DataRow row in data.Rows)
            {
                Add(new Customer(row));
            }
        }

        public new void Add(Customer customer)
        {
            base.Add(customer);
            
            OnCustomerAdded?.Invoke();
        }

        public void SaveXml()
        {
            DataAccess.SaveXml(typeof(CustomerCollection), this);
        }

        public int GetNextId()
        {
            int highest = 0;
            foreach (Customer c in this)
            {
                if (c.ID > highest) highest = c.ID;
            }

            return highest + 1;
        }
    }
}
