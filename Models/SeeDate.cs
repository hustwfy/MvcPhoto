using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPhoto.Data;
using System;
using System.Linq;

namespace MvcPhoto.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPhotoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPhotoContext>>()))
            {
                // Look for any movies.
                if (context.Photo.Any())
                {
                    return;   // DB has been seeded
                }

                context.Photo.AddRange(
                    new Photo
                    {
                        Title = "When Harry Met Sally",
                        UpDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        RANK = 99,
                        Rating = "R"
                    },

                    new Photo
                    {
                        Title = "Ghostbusters ",
                        UpDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        RANK = 77,
                        Rating = "R"
                    },

                    new Photo
                    {
                        Title = "Ghostbusters 2",
                        UpDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        RANK = 88,
                        Rating = "R"
                    },

                    new Photo
                    {
                        Title = "Rio Bravo",
                        UpDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        RANK = 100,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}