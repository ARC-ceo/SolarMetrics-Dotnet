using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarMetrics.Infrastructure.Persistence.Entitites;

namespace SolarMetrics.Infrastructure.Persistence.Mappings;

public class PainelSolarMapping : IEntityTypeConfiguration<PainelSolar>
{
    public void Configure(EntityTypeBuilder<PainelSolar> b)
    {
        b.ToTable("SM_PAINEL_SOLAR");
        
        // PK
        b.HasKey(x => x.Id);
        
        b.Property(x => x.Id)
            .ValueGeneratedNever();
        
        b.Property(x => x.Modelo)
            .HasMaxLength(200);

        b.Property(x => x.Fabricante)
            .HasMaxLength(200);
        
        b.Property(x => x.PotenciaMaxima)
            .IsRequired();
        
        b.Property(x => x.DataFabricacao)
            .IsRequired();

        b.Property(x => x.Eficiencia);
        
    }
}