using SolarSystem.Model.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace SolarSystem.Model
{
    public class SolarSystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Phones;Trusted_Connection=True; TrustServerCertificate=True;");
        }
        public DbSet<Planet> Planets { get; set; }
    }
}
