using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarMetrics.Infrastructure.Persistence.Entitites;

namespace SolarMetrics.Infrastructure.Persistence.Mappings;

public class MonitoramentoMapping : IEntityTypeConfiguration<Monitoramento>
{
    public void Configure(EntityTypeBuilder<Monitoramento> b)
    {
        b.ToTable("SM_MONITORAMENTO");
        
        // PK
        b.HasKey(x => x.Id);
        
        b.Property(x => x.Id)
            .ValueGeneratedNever();
        
        b.Property(x => x.Periodo)
            .IsRequired();

        b.Property(x => x.ValorLido)
            .IsRequired();
        
        b.Property(x => x.MediaLeitura)
            .IsRequired();
        
        b.Property(x => x.MaximaLeitura)
            .IsRequired();
        
    }
}