namespace ShoeStoreApp.Models;

public class Shoe
{
    public int ShoeId { get; set; }
    public string Name { get; set; }
    public int ShoeSize { get; set; }
    public string? ShortDescription { get; set; }
    public string? LongDescription { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageThumbnailUrl { get; set; }
    public bool IsShoeOfTheWeek { get; set; }
    public bool InStock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = default!;
}


