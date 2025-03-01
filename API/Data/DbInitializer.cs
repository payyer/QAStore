using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context) {
            // 1. Check in DB have any Product
            // =>  if have, STOP.
            // =>  if no, next Step 2.
            if(context.Products.Any()) return;

            // 2. Create a list of Product
            var products = new List<Product>
            {
                new Product { Name = "Laptop Pro", Description = "High-end laptop", Price = 25000000, PictureUrl = "https://example.com/laptop1.jpg", Type = "Electronics", Brand = "TechBrand", QuantityInStock = 50 },
                new Product { Name = "Smartphone X", Description = "Latest smartphone model", Price = 18000000, PictureUrl = "https://example.com/phone1.jpg", Type = "Electronics", Brand = "PhoneBrand", QuantityInStock = 100 },
                new Product { Name = "Wireless Headphones", Description = "Noise-cancelling headphones", Price = 5000000, PictureUrl = "https://example.com/headphones1.jpg", Type = "Accessories", Brand = "AudioBrand", QuantityInStock = 75 },
                new Product { Name = "Gaming Mouse", Description = "Ergonomic gaming mouse", Price = 1500000, PictureUrl = "https://example.com/mouse1.jpg", Type = "Accessories", Brand = "GamerBrand", QuantityInStock = 200 },
                new Product { Name = "Mechanical Keyboard", Description = "RGB mechanical keyboard", Price = 3000000, PictureUrl = "https://example.com/keyboard1.jpg", Type = "Accessories", Brand = "KeyBrand", QuantityInStock = 120 },
                new Product { Name = "Smart Watch", Description = "Fitness tracking smart watch", Price = 8000000, PictureUrl = "https://example.com/watch1.jpg", Type = "Electronics", Brand = "WatchBrand", QuantityInStock = 90 },
                new Product { Name = "Tablet Pro", Description = "Professional tablet for artists", Price = 22000000, PictureUrl = "https://example.com/tablet1.jpg", Type = "Electronics", Brand = "TabBrand", QuantityInStock = 60 },
                new Product { Name = "Portable Speaker", Description = "Bluetooth portable speaker", Price = 2500000, PictureUrl = "https://example.com/speaker1.jpg", Type = "Accessories", Brand = "AudioBrand", QuantityInStock = 110 },
                new Product { Name = "External SSD", Description = "1TB external SSD", Price = 4000000, PictureUrl = "https://example.com/ssd1.jpg", Type = "Storage", Brand = "StorageBrand", QuantityInStock = 85 },
                new Product { Name = "Drone Cam", Description = "4K camera drone", Price = 15000000, PictureUrl = "https://example.com/drone1.jpg", Type = "Electronics", Brand = "DroneBrand", QuantityInStock = 45 },
                new Product { Name = "Power Bank", Description = "Fast charging power bank", Price = 1000000, PictureUrl = "https://example.com/powerbank1.jpg", Type = "Accessories", Brand = "ChargeBrand", QuantityInStock = 130 },
                new Product { Name = "Smart TV", Description = "50-inch 4K Smart TV", Price = 12000000, PictureUrl = "https://example.com/tv1.jpg", Type = "Electronics", Brand = "TVBrand", QuantityInStock = 30 },
                new Product { Name = "VR Headset", Description = "Virtual reality headset", Price = 14000000, PictureUrl = "https://example.com/vr1.jpg", Type = "Electronics", Brand = "VRBrand", QuantityInStock = 40 },
                new Product { Name = "Electric Scooter", Description = "Foldable electric scooter", Price = 10000000, PictureUrl = "https://example.com/scooter1.jpg", Type = "Transport", Brand = "ScootBrand", QuantityInStock = 55 },
                new Product { Name = "Digital Camera", Description = "Mirrorless digital camera", Price = 18000000, PictureUrl = "https://example.com/camera1.jpg", Type = "Photography", Brand = "CameraBrand", QuantityInStock = 25 },
                new Product { Name = "Graphic Tablet", Description = "Professional graphic tablet", Price = 12000000, PictureUrl = "https://example.com/graphictab1.jpg", Type = "Electronics", Brand = "ArtBrand", QuantityInStock = 65 },
                new Product { Name = "Gaming Chair", Description = "Ergonomic gaming chair", Price = 7000000, PictureUrl = "https://example.com/chair1.jpg", Type = "Furniture", Brand = "ChairBrand", QuantityInStock = 80 },
                new Product { Name = "Fitness Tracker", Description = "Smart fitness band", Price = 1500000, PictureUrl = "https://example.com/fitness1.jpg", Type = "Wearable", Brand = "FitBrand", QuantityInStock = 95 },
                new Product { Name = "Wireless Router", Description = "Dual-band wireless router", Price = 2000000, PictureUrl = "https://example.com/router1.jpg", Type = "Networking", Brand = "NetBrand", QuantityInStock = 70 },
                new Product { Name = "Coffee Machine", Description = "Automatic coffee maker", Price = 5000000, PictureUrl = "https://example.com/coffee1.jpg", Type = "Appliances", Brand = "CoffeeBrand", QuantityInStock = 40 }
            };

            foreach(var product in products) {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}