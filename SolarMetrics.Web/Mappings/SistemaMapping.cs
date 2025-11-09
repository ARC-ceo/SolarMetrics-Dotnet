using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarMetrics.Web.Models;

namespace SolarMetrics.Web.Mappings;

public class SistemaMapping : IEntityTypeConfiguration<Sistema>
{
    public void Configure(EntityTypeBuilder<Sistema> b)
    {
        b.ToTable("SM_SISTEMA");
        
        // PK
        b.HasKey(x => x.Id);
        
        b.Property(x => x.Id)
            .ValueGeneratedNever();
        
        b.Property(x => x.NomeInstalacao)
            .IsRequired()
            .HasMaxLength(50);
        
        b.Property(x => x.DataInstalacao)
            .IsRequired();
        
        b.Property(x => x.PotenciaTotal)
            .IsRequired();
        
        b.Property(x => x.Status)
            .IsRequired()
            .HasMaxLength(50);
        
        // 1..N
        b.HasMany(x => x.Sensores)
            .WithOne(x => x.Sistema)
            .HasForeignKey(x => x.SistemaId);
        
        // 1..N
        b.HasMany(x => x.PaineisSolares)
            .WithOne(x => x.Sistema)
            .HasForeignKey(x => x.SistemaId);

    }
}