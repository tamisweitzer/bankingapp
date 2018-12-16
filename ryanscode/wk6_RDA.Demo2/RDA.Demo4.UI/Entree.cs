

using System.Collections.Generic;

namespace RDA.Demo4.UI
{
    public class Entree
    {
        public string Name { get; set; }

        public double BaseCost { get; set; }

        public double TotalCost
        {
            get
            {
                double cost = BaseCost;
                foreach (AddOn addon in AddOns)
                {
                    cost += addon.Cost;
                }
                return cost;
            }
        }

        public List<AddOn> AddOns { get; set; }

        public Entree()
        {
            AddOns = new List<AddOn>();
        }

        public Entree Clone()
        {
            Entree copy = new Entree();
            copy.Name = Name;
            copy.BaseCost = BaseCost;
            return copy;
        }
    }
}
