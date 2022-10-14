using Microsoft.EntityFrameworkCore;
using ApiVoeAirlines.Entities;
using ApiVoeAirlines.EntityConfigurations;

namespace ApiVoeAirlines.Contexts
{
    public class VoeAirlinesContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public VoeAirlinesContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Aeronave> Aeronaves => Set<Aeronave>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("VoeAirlines"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AeronaveConfiguration());
        }
    }
}