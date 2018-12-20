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
        public double DepositAmount { get; set; }
        public DateTime DepositDate { get; set; }


        public Deposit() { }

        public Deposit(double depositamount, DateTime depositdate)
        {
            DepositAmount = depositamount;
            DepositDate = depositdate;
        }

        

    }
}
