using ApsNetCore6.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApsNetCore6
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Products> Products { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        { }
    }
}
