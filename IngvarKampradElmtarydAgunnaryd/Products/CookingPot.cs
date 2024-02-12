using IngvarKampradElmtarydAgunnaryd.Interfaces;

namespace IngvarKampradElmtarydAgunnaryd.Products
{
    public class CookingPot : Product, IKitchen
    {
        public CookingPot(string names, float prices, string shelf, string desc) : base(names, prices, shelf, desc)
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

        public string Kitchen()
        {
            return $"This {Names} is perfect for the kitchen, it is functional.";
        }

        public CookingPot()
            : base("CookingPot", 29.99f, "Kitchen", "Stainless steel cooking pot")
        {
            
        }
    }
}