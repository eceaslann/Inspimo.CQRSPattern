using Microsoft.EntityFrameworkCore;

namespace Inspimo.CQRSPattern.DAL
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RCI54VP; initial catalog= InspimoCQRSDb; integrated security= true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
