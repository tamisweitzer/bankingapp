using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.BankingApp.BL;

namespace TSS.BankingApp.BL
{
    public class CustomerCollection: List<Customer>
    {

        public void Populate()
        {
            // create three customers w/ 3 dep, and 3 withdrawls each 

            Customer c;

            // 1st Customer
            c = new Customer();
            c.CustomerID = 100;
            c.FirstName = "Mary";
            c.LastName = "Swan";
            c.BirthDate = new DateTime(12, 04, 1960);
            c.LastDeposit = new Deposit();
            c.LastWithdrawl = new Withdrawl();
            Add(c);

            // 2nd Customer
            c = new Customer();
            c.CustomerID = 200;
            c.FirstName = "Jeremy";
            c.LastName = "Swanson";
            c.BirthDate = new DateTime(01, 07, 1971);
            c.LastDeposit = new Deposit();
            c.LastWithdrawl = new Withdrawl();
            Add(c);

            // 3rd Customer
            c = new Customer();
            c.CustomerID = 300;
            c.FirstName = "Kelly";
            c.LastName = "Green";
            c.BirthDate = new DateTime(06, 23, 1976);
            c.LastDeposit = new Deposit();
            c.LastWithdrawl = new Withdrawl();
            Add(c);
        }
    }
}
