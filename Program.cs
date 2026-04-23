using CsBases.Fundamentals;

class Program
{
    static void Main()
    {


        var laptop = new Product("Laptop", 1200);
        WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte Técnico", 300, 30);
        WriteLine(soporte.GetDescription());

        var product = new Product("Mouse Gamer", 300);
        var productDTO = ProductAdapter.ToDTO(product);
        WriteLine($"{productDTO.Name} - {productDTO.Price:C} - Código: {productDTO.Code}");
    }
}