using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().HasData(
        //       new Category
        //       {
        //           Id = 1,
        //           Name = "Apple",
        //           DisplayOrder = 1
        //       },
        //       new Category
        //       {
        //           Id=2,
        //           Name = "Samsung",
        //           DisplayOrder = 2,
        //       }
        //        );
        //}
    }
}
