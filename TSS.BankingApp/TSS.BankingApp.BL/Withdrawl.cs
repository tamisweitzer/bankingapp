using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.BankingApp.BL
{
    public class Withdrawl
    {
        
        public int WithdrawlID { get; set; }
        public double WithdrawlAmount { get; set; }
        public DateTime WithdrawlDate { get; set; }

        public Withdrawl() { } 

        public Withdrawl(double withdrawlamount)
        {
           WithdrawlAmount = withdrawlamount;
        }
    }

    
}
