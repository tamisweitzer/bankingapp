using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.BankingApp.BL
{
    public class DepositList : List<Deposit>
    {
        public static void Add()
        {
            
        }


        public int IncrementID()
        {
            int _id = 100;

            foreach (Deposit d in this)
            {
                if (d.DepositID > _id)
                { _id = d.DepositID; }
                else
                { _id++; }
            }
            return _id;

        }
    }
}
