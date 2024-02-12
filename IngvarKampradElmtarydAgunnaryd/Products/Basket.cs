using IngvarKampradElmtarydAgunnaryd.Interfaces;

namespace IngvarKampradElmtarydAgunnaryd.Products;

public class Basket: Product, ILivingRoom, IBedroom
{
    public Basket(string names, float prices, string shelf, string desc) : base(names, prices, shelf, desc)
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

    public string Bedroom()
    {
        return $"This {Names} is perfect for the bedroom, it is gorgeous.";
    }

    public Basket()
    :base("Basket", 499.79f, "900", "Pretty basket")
    {
        
    }
}