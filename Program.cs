using CsBases.Fundamentals;

class Program
{
    static void Main()
    {
        int quantity = 5;
        string message = "Hello World";
        decimal price = 19.99m;
        WriteLine($"Cantidad: {quantity}, Saludo: {message}, Precio: {price:C}");
        //Vars
        var greeting = "Hola";
        var percentage = 20.00m;
        WriteLine($"Saludo: {greeting}, Porcentaje: {percentage}");

        var laptop = new Product("Laptop", 1200);
        WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte Técnico", 300, 30);
        WriteLine(soporte.GetDescription());
    }
}