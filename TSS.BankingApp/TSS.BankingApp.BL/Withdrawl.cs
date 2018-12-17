using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.BankingApp.BL
{
    public class Withdrawl
    {
        // props
        public int ID;
        public double Amount;
        public DateTime Date;

        public Withdrawl(double amount)
        {
            Amount = amount;
            Date = new DateTime();
        }
    }
}
