using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class KimiWomanContext : DbContext
    {
        public KimiWomanContext(DbContextOptions<KimiWomanContext> options) : base(options)
        {

        }

        public DbSet<Products> Productos { get; set; }
        public DbSet<Variaciones> Variaciones { get; set; }
        public DbSet<Images> Imagenes { get; set; }
    }
}