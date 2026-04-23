using CsBases.Fundamentals;

public class ProductAdapter
{

    public static ProductDTO ToDTO(Product product)
    {
        return new ProductDTO
        {
            Name = product.GetDescription(),
            Price = product.Price,
            Code = $"P-{product.Id}-{product.UniqueCode.ToString().Substring(0, 8)}"
        };
    }

}