using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.BankingApp.BL
{
    public class Deposit
    {
        
        public int DepositID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }


        public Deposit(double amount)
        {
            Amount = amount;
        }

        
    }
}
