namespace SolarMetrics.Web.Models;

public class Sistema
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string NomeInstalacao { get; set; }
    public DateOnly DataInstalacao { get; set; }
    public int PotenciaTotal { get; set; }
    public string Status { get; set; }
    
    // N..1
    public Guid ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    
    // 1..N
    public List<PainelSolar> PaineisSolares { get; set; }
    
    // 1..N
    public List<Sensor> Sensores { get; set; }
}