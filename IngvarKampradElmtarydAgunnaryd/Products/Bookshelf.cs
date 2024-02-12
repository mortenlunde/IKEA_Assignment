using IngvarKampradElmtarydAgunnaryd.Interfaces;

namespace IngvarKampradElmtarydAgunnaryd.Products;

public class Bookshelf:Product, IAssemblable, IOffice, ILivingRoom
{
    private string? _assemblySteps;
    public Bookshelf(string names, float prices, string shelf, string desc) : base(names, prices, shelf, desc)
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

    public string Office()
    {
        return $"This {Names} is perfect for the office, it is gorgeous.";
    }

    public string LivingRoom()
    {
        return $"This {Names} is perfect for the living room, it is gorgeous.";
    }

    public string? Assemble()
    {
        return _assemblySteps;
    }

    public string GetAssemblySteps()
    {
        return ReadAssembelyStepsFromDb();
    }

    public Bookshelf()
        : base("Bookshelf", 800f, "225", "Hold your books")
    {
        
    }
}