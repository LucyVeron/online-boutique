using Microsoft.EntityFrameworkCore;
using OnlineBoutique.Data;

namespace OnlineBoutique.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new OnlineBoutiqueContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<OnlineBoutiqueContext>>()))
        {
            if (context == null || context.Product == null)
            {
                throw new ArgumentNullException("Null OnlineBoutiqueContext");
            }

            // Look for any movies.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            context.Product.AddRange(
                new Product
                {
                    Name = "Perfume",
                    Description = "A captivating blend of floral and warm notes, perfect for any occasion.",
                    Price = 39.99M,
                    Category = "Perfumes"
                },
                new Product
                {
                    Name = "Lip Gloss",
                    Description = "Shine and color meet hydration in this long-lasting, non-sticky gloss.",
                    Price = 34.99M,
                    Category = "Makeup"
                },
                new Product
                {
                    Name = "Hair Bow",
                    Description = "Effortlessly elevate your look with this elegant satin bow.",
                    Price = 9.99M,
                    Category = "Accessories"
                },
                new Product
                {
                    Name = "Earrings",
                    Description = "Sophisticated and lightweight earrings that add elegance to any outfit.",
                    Price = 14.99M,
                    Category = "Jewelry"
                },
                new Product
                {
                    Name = "Eyeshadow Palette",
                    Description = "A versatile palette with rich shades for endless, blendable looks.",
                    Price = 34.99M,
                    Category = "Makeup"
                }
            );
            context.SaveChanges();
        }
    }
}