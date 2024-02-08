using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                },
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                },
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                },
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                },
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                },
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                },
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                },
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                },
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                },
		        new Product
                {
                    Name = "Heart and Flower Earrings",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5000,
                    PictureUrl = "images/earrings.jpeg",
                    Brand = "Bijou",
                    Category = "Earrings",
                    QuantityInStock = 5
                }                                                                                                                
            };
            
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}