using System.Threading.Tasks;
using CsBases.Fundamentals;

class Program
{
    static async Task Main()
    {

        /*
            var laptop = new Product("Laptop", 1200);
            WriteLine(laptop.GetDescription());
            var soporte = new ServiceProduct("Soporte Técnico", 300, 30);
            WriteLine(soporte.GetDescription());

            var product = new Product("Mouse Gamer", 300);
            var productDTO = ProductAdapter.ToDTO(product);
            WriteLine($"{productDTO.Name} - {productDTO.Price:C} - Código: {productDTO.Code}");

            //Inyeccion de dependecias
            ILabelService labelService = new LabelService();
            var manager = new ProductManager(labelService);
            var monitor = new Product("Monitor", 100);
            var installation = new ServiceProduct("Instalación de monitor", 20, 30);
            manager.PrintLabel(monitor);
            manager.PrintLabel(installation);
            */

        var firstProduct = await new ProductRepository().GetProduct(1);
        WriteLine($"{firstProduct.Name} - {firstProduct.Price:C}");

    }
}