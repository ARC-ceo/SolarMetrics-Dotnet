using Microsoft.EntityFrameworkCore;
using SolarMetrics.Web.Mappings;
using SolarMetrics.Web.Models;

namespace SolarMetrics.Web;

public class SolarMetricsContext : DbContext
{
    public SolarMetricsContext(DbContextOptions<SolarMetricsContext> options) : base(options)
    {
        
    }
    
    public DbSet<Sistema> Sistemas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Monitoramento> Monitoramentos { get; set; }
    public DbSet<PainelSolar> PaineisSolares { get; set; }
    public DbSet<Sensor> Sensores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClienteMapping());
        modelBuilder.ApplyConfiguration(new MonitoramentoMapping());
        modelBuilder.ApplyConfiguration(new PainelSolarMapping());
        modelBuilder.ApplyConfiguration(new SensorMapping());
        modelBuilder.ApplyConfiguration(new SistemaMapping());
        base.OnModelCreating(modelBuilder);
    }
}