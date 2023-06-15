using Microsoft.EntityFrameworkCore;
using StudentInfoAPI.Models;

namespace StudentInfoAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
