using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_Inventory
{
    public interface IShippable
    {
        public double ShipCost { get; set; }
        public string Product { get; set; }
    }

    public class item : IShippable
    {
        public double ShipCost { get; set; }
        public string Product { get; set; }

        public  item(double shipCost, string product) 
        {
            ShipCost = shipCost;
            Product = product;
        }
    }
}
