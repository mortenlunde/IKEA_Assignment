using IngvarKampradElmtarydAgunnaryd.Interfaces;

namespace IngvarKampradElmtarydAgunnaryd.Products
{
    public class Sofa : Product, ILivingRoom
    {
        public Sofa(string names, float prices, string shelf, string desc) : base(names, prices, shelf, desc)
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

        public Sofa()
            : base("Sofa", 24999, "200", "Italian leather fra Lamborghini- bulls")
        {
            
        }
    }
}