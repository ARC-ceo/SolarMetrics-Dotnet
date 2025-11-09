namespace SolarMetrics.Web.Models;

public class PainelSolar
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Modelo { get; set; }
    public string Fabricante { get; set; }
    public int PotenciaMaxima { get; set; }
    public int DataFabricacao { get; set; }
    public int Eficiencia { get; set; }
    
    // N..1
    public Guid SistemaId { get; set; }
    public Sistema Sistema { get; set; }
}