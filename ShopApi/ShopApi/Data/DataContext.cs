using Microsoft.EntityFrameworkCore;
using ShopApi.Models;

namespace ShopApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
