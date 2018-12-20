using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAloneProject
{
    class CustomerCollection : List<Customer>
    {

        // populates the hard-coded test data into the form
        public void PopulateTestData()
        {
            // First create the test customers
            Customer c;

            // First customer
            c = new Customer();
            c.CustomerID = 1;
            c.FirstName = "Aurora";
            c.LastName = "Flannery";
            c.DepositAmount = 120500.00;


            // Second customer
            c = new Customer();
            c.CustomerID = 1;
            c.FirstName = "Jimmy";
            c.LastName = "Brooks";
            c.DepositAmount = 523.50;


            // Third customer
            c = new Customer();
            c.CustomerID = 1;
            c.FirstName = "Anita";
            c.LastName = "Silver";
            c.DepositAmount = 500.00;
        }
    }
}
