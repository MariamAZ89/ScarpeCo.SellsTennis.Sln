using ScarpeCo.SellsTennis.Models;

namespace ScarpeCo.SellsTennis.Repositories;

public static class ProductRepository
{
    public static List<Product> GetProducts() => _products;
    public static Product? GetById(int id) => _products.FirstOrDefault(o => o.Id == id);

    private static List<Product> _products = new()
    {
        new Product
        {
            Id = 1, Name = "Tennis Shoes 1", Price = 100.00f,
            Description = "The best tennis shoes you can find.",
            CoverImage = "/images/products/tennis.jpg",
            AdditionalImages = new List<string>
            {
                "/images/products/ATP.jpg",
                "/images/products/Danloup1.jpg",
                "/images/products/RUN.jpg"
            }
        },
        new Product
        {
            Id = 2, Name = "Tennis Shoes 2", Price = 120.00f,
            Description = "The best tennis shoes you can find.",
            CoverImage = "/images/products/product2.jpg",
            AdditionalImages = new List<string>
            {
                "/images/products/Tour.jpg",
                "/images/products/Wilson.jpg",
                "/images/products/Yueshong.jpg"
            }
        },
        new Product
        {
            Id = 3, Name = "Tennis Shoes 3", Price = 130.00f,
            Description = "The best tennis shoes you can find.",
            CoverImage = "/images/products/Yueshong.jpg",
            AdditionalImages = new List<string>
            {
                "/images/products/tennis.jpg",
                "/images/products/Yueshong.jpg",
                "/images/products/tennis.jpg"
            }
        },
        new Product
        {
            Id = 4, Name = "Tennis Shoes 4", Price = 140.00f,
            Description = "The best tennis shoes you can find.",
            CoverImage = "/images/products/tennis.jpg",
            AdditionalImages = new List<string>
            {
                "/images/products/Wilson.jpg",
                "/images/products/tennis.jpg",
                "/images/products/Yueshong.jpg"
            }
        },
        new Product
        {
            Id = 5, Name = "Tennis Shoes 5", Price = 150.00f,
            Description = "The best tennis shoes you can find.",
            CoverImage = "/images/products/tennis.jpg",
            AdditionalImages = new List<string>
            {
                "/images/products/tennis.jpg",
                "/images/products/Yueshong.jpg",
                "/images/products/Wilson.jpg"
            }
        },
        new Product
        {
            Id = 6, Name = "Tennis Shoes 6", Price = 160.00f,
            Description = "The best tennis shoes you can find.",
            CoverImage = "/images/products/tennis.jpg",
            AdditionalImages = new List<string>
            {
                "/images/products/tennis.jpg",
                "/images/products/tennis.jpg",
                "/images/products/Wilson.jpg"
            }
        }
    };
}