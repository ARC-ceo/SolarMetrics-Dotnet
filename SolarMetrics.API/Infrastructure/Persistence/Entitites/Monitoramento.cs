namespace SolarMetrics.Infrastructure.Persistence.Entitites;

public class Monitoramento
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateOnly Periodo { get; set; }
    public int ValorLido { get; set; }
    public int MediaLeitura { get; set; }
    public int MaximaLeitura { get; set; }
    
    // N..1
    public Guid SensorId { get; set; }
    public Sensor Sensor { get; set; }
}