using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.BankingApp.BL
{
    public class Customer : Person
    {
        // Field 
        private DataRow datarow;


        // Properties
        public int CustomerID { get; set; }
        public Deposit LastDeposit { get; set;}  
        public Withdrawl LastWithdrawl { get; set; }   
        public List<Deposit> DepositList { get; set; } 
        public List<Withdrawl> WithdrawlList { get; set; }  


        // Constructors 
        public Customer()
        {
            DepositList = new List<Deposit>();
            WithdrawlList = new List<Withdrawl>();

        }

        public Customer( int customerid)
        {
            DepositList = new List<Deposit>();
            WithdrawlList = new List<Withdrawl>();
            CustomerID = customerid;
        }

        public Customer(int customerid, Deposit lastdeposit)
        {
            DepositList = new List<Deposit>();
            WithdrawlList = new List<Withdrawl>();
            CustomerID = customerid;
            LastDeposit = lastdeposit;
        }

        public Customer(int customerid, Withdrawl lastwithdrawl)
        {
            DepositList = new List<Deposit>();
            WithdrawlList = new List<Withdrawl>();
            CustomerID = customerid;
            LastWithdrawl = lastwithdrawl;
        }

        public Customer(int customerid, Deposit lastdeposit, Withdrawl lastwithdrawl)
        {
            DepositList = new List<Deposit>();
            WithdrawlList = new List<Withdrawl>();
            CustomerID = customerid;
            LastDeposit = lastdeposit;
            LastWithdrawl = lastwithdrawl;

        }

        public Customer(DataRow datarow)
        {
            DepositList = new List<Deposit>();
            WithdrawlList = new List<Withdrawl>();
            ID = Convert.ToString(datarow["ID"]);
            Amount = Convert.ToString(datarow["Amount"]);
            DateTime = Convert.ToString(datarow["Date"]);

        }

    }
}
