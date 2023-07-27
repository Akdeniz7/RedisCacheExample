using Microsoft.EntityFrameworkCore;
using RedisCacheExample.Model;

namespace RedisCacheExample
{
    public class DbContextClass: DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) { }
        public DbSet<Product> Products {get; set;}
    }
}
