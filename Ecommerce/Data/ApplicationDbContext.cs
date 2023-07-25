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
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCover> BookCovers { get; set; }
        public DbSet<BookWriter> Writers { get; set; }  

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
