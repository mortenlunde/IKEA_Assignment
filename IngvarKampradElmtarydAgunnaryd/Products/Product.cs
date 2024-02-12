namespace IngvarKampradElmtarydAgunnaryd.Products;

public abstract class Product
{
    protected readonly string Names;
    protected readonly float Prices;
    protected readonly string Shelf;
    protected readonly string Desc;

    protected Product(string names, float prices, string shelf, string desc)
    {
        Names = names;
        Prices = prices;
        Shelf = "222" + shelf;
        Desc = desc;
    }

    public abstract float Price();

    public abstract string GetShelf();
    
    public abstract string Descrition();

    protected static string ReadAssembelyStepsFromDb()
    {
        return "Do not assemble alone. Follow step 1-21.";
    }
}