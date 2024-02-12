using IngvarKampradElmtarydAgunnaryd.Interfaces;

namespace IngvarKampradElmtarydAgunnaryd.Products
{
    public class Lamp : Product, ILivingRoom
    {
        public Lamp(string names, float prices, string shelf, string desc) : base(names, prices, shelf, desc)
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
            return $"This {Names} is perfect for the living room, it provides cozy lighting.";
        }

        public Lamp()
            : base("Lamp", 49.99f, "412", "Modern floor lamp")
        {
            
        }
    }
}