﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.BankingApp.BL
{
    public delegate void WithdrawlItemAdded();


    public class WithdrawlList: List<Withdrawl>
    {
        public WithdrawlItemAdded OnWithrdrawlItemAdded { get; set; }

        public void PopulateWithdrawlItems()
        {

        }



        public int IncrementID()
        {
            int _id = 100;

            foreach (Withdrawl w in this)
            {
                if (w.WithdrawlID > _id)
                { _id = w.WithdrawlID; }
                else
                { _id++; }
            }
            return _id;

        }
    }
}
