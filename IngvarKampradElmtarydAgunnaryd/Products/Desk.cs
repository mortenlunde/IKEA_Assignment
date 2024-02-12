using IngvarKampradElmtarydAgunnaryd.Interfaces;

namespace IngvarKampradElmtarydAgunnaryd.Products
{
    public class Desk : Product, IAssemblable, IOffice
    {
        private string? _assemblySteps;

        public Desk(string names, float prices, string shelf, string desc) : base(names, prices, shelf, desc)
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

        public Desk()
            : base("Desk", 299, "4", "Oak")
        {
           
        }

        public string Office()
        {
            return $"This {Names} is perfect for the office, it is gorgeous.";
        }
    }
}