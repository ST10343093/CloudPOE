namespace khumalocraft2._2.Models
{
    public class Product { 
     public int ProductId { get; set; }

    public string? Name { get; set; } = null!;

    public decimal? Price { get; set; }

    public string? Category { get; set; } = null!;

    public string? ImageUrl { get; set; } = null!;

    public bool? Availability { get; set; }

}
}
