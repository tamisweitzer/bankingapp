
using System.Collections.Generic;

namespace RDA.Demo4.UI
{
    public class Order
    {
        public List<Entree> Items { get; set; }

        public Order()
        {
            Items = new List<Entree>();
        }

        public double Total
        {
            get
            {
                double total = 0;
                foreach (Entree entree in Items)
                {
                    total += entree.TotalCost;
                }
                return total;
            }
        }
    }
}
