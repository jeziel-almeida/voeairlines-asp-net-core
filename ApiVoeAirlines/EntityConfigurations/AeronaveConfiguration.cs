using Microsoft.EntityFrameworkCore;
using ApiVoeAirlines.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiVoeAirlines.EntityConfigurations
{
    public class AeronaveConfiguration : IEntityTypeConfiguration<Aeronave>
    {
        public void Configure(EntityTypeBuilder<Aeronave> builder)
        {
            builder.ToTable("tb_aeronaves");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Fabricante).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Modelo).IsRequired();
            builder.Property(x => x.Codigo).IsRequired();
            builder.Property(x => x.Tipo).IsRequired();
        }
    }
}