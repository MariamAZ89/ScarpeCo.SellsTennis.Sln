namespace ScarpeCo.SellsTennis.Models;
public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; } = null!;
    public required string Description { get; set; } = null!;
    public float Price { get; set; }
    public required string CoverImage { get; set; }
    public List<string> AdditionalImages { get; set; } = new List<string>();
}