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

            // when it's all hardcoded, everything loads
            // 1st Customer
            c = new Customer();
            c.CustomerID = 100;
            c.FirstName = "Mary";
            c.LastName = "Swan";
            c.SSN = "327-51-5847";
            c.BirthDate = new DateTime(1959, 01, 06);
            c.LastDeposit = new Deposit(150.57, new DateTime(2017, 01, 02));
            c.LastWithdrawl = new Withdrawl(6958.21);
            Add(c);

            ////  Customer
            //c = new Customer();
            //c.CustomerID = 100;
            //c.FirstName = "Mary";
            //c.LastName = "Swan";
            //c.SSN = "327-51-5847";
            //c.BirthDate = new DateTime(1959, 01, 06);
            ////c.DepositList.Add(new Deposit()
            ////{
            ////    DepositID = 10010,
            ////    Amount = 516.24,
            ////    Date = new DateTime(2018, 12, 19)});
            //// Hard coding these because I don't know how to make the list work
            //c.LastDeposit = new Deposit(150.57, new DateTime(2018, 10, 15));
            ////c.LastDeposit.DepositDate = new DateTime(2018, 11, 24);
            //c.LastWithdrawl = new Withdrawl(6958.21);
            //c.LastWithdrawl.WithdrawlDate = new DateTime(2018, 11, 25);
            //Add(c);


            // 2nd Customer
            c = new Customer();
            c.CustomerID = 200;
            c.FirstName = "Jeremy";
            c.LastName = "Swanson";
            c.SSN = "327-62-6958";
            c.BirthDate = new DateTime(1970, 06, 15);
            c.Deposits.Add(new Deposit()
            {
                DepositID = 20010,
                DepositAmount = 3501.98,
                DepositDate = new DateTime(2018, 10, 11),
            });
            c.Deposits.Add(new Deposit()
            {
                DepositID = 20011,
                DepositAmount = 1203.72,
                DepositDate = new DateTime(2018, 10, 24)
            });
            c.Deposits.Add(new Deposit() {
                DepositID = 20012,
                DepositAmount = 1107.54,
                DepositDate = new DateTime(2018, 10, 29)
            });
            // do withdrawl
            Add(c);


            // 3rd Customer
            c = new Customer();
            c.CustomerID = 300;
            c.FirstName = "Kelly";
            c.LastName = "Green";
            c.SSN = "327-73-7069";
            c.BirthDate = new DateTime(1982, 11, 25);
            c.LastDeposit = new Deposit(65.37, new DateTime(2018, 10, 25));
            c.LastWithdrawl = new Withdrawl(951.55);
            Add(c);
        }

        public int IncrementID()
        {
            int _id = 100;

            foreach (Customer c in this)
            {
                if (c.CustomerID > _id)
                { _id = c.CustomerID; }
                else
                { _id++; }
            }
            return _id;
            
        }
    }
}
