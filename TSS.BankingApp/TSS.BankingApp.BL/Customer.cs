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
        private object DisplayName;

               
        // Properties
        public int CustomerID { get; set; }
        public Deposit LastDeposit { get; set; }
        public Withdrawl LastWithdrawl { get; set; }
        public List<Deposit> Deposits { get; set; }
        public List<Withdrawl> Withdrawls { get; set; }
       

        // Constructors 
        public Customer()
        {
            Deposits = new List<Deposit>();
            Withdrawls = new List<Withdrawl>();
        }

        public Customer(int customerid)
        {
            Deposits = new List<Deposit>();
            Withdrawls = new List<Withdrawl>();
            CustomerID = customerid;
        }

        public Customer(int customerid, string firstname, string lastname, string ssn, DateTime birthdate )
        {
            Deposits = new List<Deposit>();
            Withdrawls = new List<Withdrawl>();
            CustomerID = customerid;
            FirstName = firstname;
            LastName = lastname;
            SSN = ssn;
            BirthDate = birthdate;
        }

        public Customer(DataRow row)
        {
            CustomerID = Convert.ToInt32(row["CustomerID"]);

            Deposits = new List<Deposit>();
            Withdrawls = new List<Withdrawl>();
        }



    }
}
