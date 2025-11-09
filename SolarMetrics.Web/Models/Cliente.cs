namespace SolarMetrics.Web.Models;

public class Cliente
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string TipoUsuario { get; set; }
    
    // 1..N
    public List<Sistema> Sistemas { get; set; }
}