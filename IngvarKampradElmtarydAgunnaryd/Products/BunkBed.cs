using IngvarKampradElmtarydAgunnaryd.Interfaces;

namespace IngvarKampradElmtarydAgunnaryd.Products
{
    public class BunkBed : Product, IAssemblable, IBedroom
    {
        private string? _assemblySteps;

        public BunkBed(string names, float prices, string shelf, string desc) : base(names, prices, shelf, desc)
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

        public string? Assemble()
        {
            return _assemblySteps;
        }

        public string GetAssemblySteps()
        {
            return ReadAssembelyStepsFromDb();
        }

        public BunkBed()
            : base("BunkBed", 999, "749", "2 etages bed")
        {
            
        }

        public string Bedroom()
        {
            return $"This {Names} is perfect for the bedroom, it is gorgeous.";
        }
    }
}