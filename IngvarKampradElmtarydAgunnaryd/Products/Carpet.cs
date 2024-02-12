using IngvarKampradElmtarydAgunnaryd.Interfaces;

namespace IngvarKampradElmtarydAgunnaryd.Products;

public class Carpet: Product, ILivingRoom, IOffice, IBedroom
{
    public Carpet(string names, float prices, string shelf, string desc) : base(names, prices, shelf, desc)
    {
    }

    public override float Price()
    {
        return Prices;
    }

    public override string GetShelf()
    {
        return Shelf;
    }

    public override string Descrition()
    {
        return Desc;
    }

    public string LivingRoom()
    {
        return $"This {Names} is perfect for the living room, it is gorgeous.";
    }

    public string Office()
    {
        return $"This {Names} is perfect for the office, it is gorgeous.";
    }

    public string Bedroom()
    {
        return $"This {Names} is perfect for the bedroom, it is gorgeous.";
    }

    public Carpet()
        : base("Carpet", 399.5f, "345", "Nice")
    {
        
    }
}