using IngvarKampradElmtarydAgunnaryd.Interfaces;
using IngvarKampradElmtarydAgunnaryd.Products;

namespace IngvarKampradElmtarydAgunnaryd;
// AKA IKEA

internal static class Program
{
    internal static void Main()
    {
        List<Product> products =
        [
            new Carpet(),
            new Bookshelf(),
            new Basket(),
            new Desk(),
            new Lamp(),
            new Sofa(),
            new BunkBed(),
            new CookingPot()
        ];

        foreach (Product product in products)
        {
            switch (product)
            {
                case IAssemblable assemblableProduct:
                    Console.WriteLine(assemblableProduct.GetAssemblySteps());
                    break;

                case IOffice officeProduct:
                    Console.WriteLine(officeProduct.Office());
                    break;

                case IBedroom bedroomProduct:
                    Console.WriteLine(bedroomProduct.Bedroom());
                    break;

                case IKitchen kitchenProduct:
                    Console.WriteLine(kitchenProduct.Kitchen());
                    break;

                case ILivingRoom livingroomProduct:
                    Console.WriteLine(livingroomProduct.LivingRoom());
                    break;
            }
        }
    }
}