using Microsoft.EntityFrameworkCore;
using MvcPhoto.Models;

namespace MvcPhoto.Data
{
    public class MvcPhotoContext : DbContext
    {
        public MvcPhotoContext(DbContextOptions<MvcPhotoContext> options)
            : base(options)
        {
        }

        public DbSet<Photo> Photo { get; set; }
    }
}