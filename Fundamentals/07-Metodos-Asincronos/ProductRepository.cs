using CsBases.Fundamentals;
public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        // Simulación de obtención de producto desde una base de datos
        WriteLine("Buscando producto...");
        await Task.Delay(2000); // Simula demora en la consulta
        return new Product($"Producto Simulado", 500);
    }
}