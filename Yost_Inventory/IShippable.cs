namespace Yost_Inventory
{
    internal interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
