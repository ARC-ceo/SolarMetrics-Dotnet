using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarMetrics.Web.Models;

namespace SolarMetrics.Web.Mappings;

public class ClienteMapping : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> b)
    {
        b.ToTable("SM_USUARIO");
        
        // PK
        b.HasKey(x => x.Id);
        
        b.Property(x => x.Id)
            .ValueGeneratedNever();
        
        b.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(200);
        
        b.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(200);
        
        b.HasIndex(x => x.Email)
            .IsUnique();
        
        b.Property(x => x.TipoUsuario)
            .IsRequired()
            .HasMaxLength(50);
        
        b.Property(x => x.Telefone)
            .IsRequired(false)
            .HasMaxLength(11);
        
        // 1..N
        b.HasMany(x => x.Sistemas)
            .WithOne(x => x.Cliente)
            .HasForeignKey(x => x.ClienteId);

    }
}