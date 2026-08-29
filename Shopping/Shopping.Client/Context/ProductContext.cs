using Shopping.Client.Models;

namespace Shopping.Client.Context
{
    public static class ProductContext
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = "1", Name = "Wireless Mouse", Category = "Electronics", Description = "Ergonomic wireless mouse with USB receiver.", ImageFile = "mouse.jpg", Price = 19.99m },
            new Product { Id = "2", Name = "Mechanical Keyboard", Category = "Electronics", Description = "RGB backlit mechanical keyboard.", ImageFile = "keyboard.jpg", Price = 49.99m },
            new Product { Id = "3", Name = "Running Shoes", Category = "Footwear", Description = "Lightweight running shoes for daily training.", ImageFile = "shoes.jpg", Price = 59.99m },
            new Product { Id = "4", Name = "Coffee Mug", Category = "Home", Description = "Ceramic coffee mug, 12oz capacity.", ImageFile = "mug.jpg", Price = 9.99m },
            new Product { Id = "5", Name = "Backpack", Category = "Accessories", Description = "Water-resistant travel backpack.", ImageFile = "backpack.jpg", Price = 39.99m },
            new Product { Id = "6", Name = "Bluetooth Speaker", Category = "Electronics", Description = "Portable speaker with 10-hour battery life.", ImageFile = "speaker.jpg", Price = 29.99m },
            new Product { Id = "7", Name = "Desk Lamp", Category = "Home", Description = "LED desk lamp with adjustable brightness.", ImageFile = "lamp.jpg", Price = 24.99m },
            new Product { Id = "8", Name = "Yoga Mat", Category = "Fitness", Description = "Non-slip yoga mat for home workouts.", ImageFile = "yogamat.jpg", Price = 15.99m },
            new Product { Id = "9", Name = "Sunglasses", Category = "Accessories", Description = "UV-protection polarized sunglasses.", ImageFile = "sunglasses.jpg", Price = 12.99m },
            new Product { Id = "10", Name = "Water Bottle", Category = "Fitness", Description = "Insulated stainless steel water bottle, 24oz.", ImageFile = "bottle.jpg", Price = 14.99m }
        };
    }
}
