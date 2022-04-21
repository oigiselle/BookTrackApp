using Microsoft.EntityFrameworkCore;
using BookTrack_Models;
using System;

namespace BookTrack_Data
{
    public class RetailDbContext : DbContext
    {
        public RetailDbContext(DbContextOptions<RetailDbContext> options) 
            : base(options) 
        {
        
        }
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryType> CategoriesType { get; set; }
    }
}
