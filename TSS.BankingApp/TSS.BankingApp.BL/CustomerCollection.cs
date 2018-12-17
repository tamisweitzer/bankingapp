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
            c.SSN = "327-51-5847";
            c.BirthDate = new DateTime(1959, 01, 06);
            c.LastDeposit = new Deposit(150.57);
            c.LastWithdrawl = new Withdrawl(25.00);
            Add(c);


            // 2nd Customer
            c = new Customer();
            c.CustomerID = 200;
            c.FirstName = "Jeremy";
            c.LastName = "Swanson";
            c.SSN = "327-62-6958";
            c.BirthDate = new DateTime(1970, 06, 15);
            c.LastDeposit = new Deposit(3501.98);
            c.LastWithdrawl = new Withdrawl(1601.58);
            Add(c);


            // 3rd Customer
            c = new Customer();
            c.CustomerID = 300;
            c.FirstName = "Kelly";
            c.LastName = "Green";
            c.SSN = "327-73-7069";
            c.BirthDate = new DateTime(1982, 11, 25);
            c.LastDeposit = new Deposit(65.37);
            c.LastWithdrawl = new Withdrawl(951.55);
            Add(c);
        }
    }
}
