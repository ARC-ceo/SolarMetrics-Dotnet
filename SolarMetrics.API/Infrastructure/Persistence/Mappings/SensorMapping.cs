using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarMetrics.Infrastructure.Persistence.Entitites;

namespace SolarMetrics.Infrastructure.Persistence.Mappings;

public class SensorMapping : IEntityTypeConfiguration<Sensor>
{
    public void Configure(EntityTypeBuilder<Sensor> b)
    {
        b.ToTable("SM_SENSOR");
        
        // PK
        b.HasKey(x => x.Id);
        
        b.Property(x => x.Id)
            .ValueGeneratedNever();
        
        b.Property(x => x.Tipo)
            .IsRequired()
            .HasMaxLength(50);

        b.Property(x => x.Status)
            .IsRequired()
            .HasMaxLength(50);
        
        b.Property(x => x.Localizacao)
            .IsRequired()
            .HasMaxLength(100);
        
        // 1..N
        b.HasMany(x => x.Monitoramentos)
            .WithOne(x => x.Sensor)
            .HasForeignKey(x => x.SensorId);
        
    }
}