namespace Hunt_Inventory
{
    //calculates items and ship cost
    public class Shipper
    {
        double totShipCost;
        public double Add(IShippable item)
        {
            totShipCost = totShipCost + item.ShipCost;
            return totShipCost;
        }
        public double Total()
        {
            return totShipCost;
        }
    }
}
