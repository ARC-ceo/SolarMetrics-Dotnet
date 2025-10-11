namespace SolarMetrics.Infrastructure.Persistence.Entitites;

public class Sensor
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Tipo { get; set; }
    public string Status { get; set; }
    public string Localizacao { get; set; }
    
    // N..1
    public Guid SistemaId { get; set; }
    public Sistema Sistema { get; set; }
    
    // 1..N
    public List<Monitoramento> Monitoramentos { get; set; }
}