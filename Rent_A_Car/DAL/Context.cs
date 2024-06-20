using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Rent_A_Car.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HHOE249\\SQLEXPRESS;initial Catalog=DbRentACar;integrated Security=true");
        }
        public DbSet<Car> Cars { get; set; }
    }
}
