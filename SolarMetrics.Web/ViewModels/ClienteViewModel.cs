
using SolarMetrics.Web.Models;

namespace SolarMetrics.Web.ViewModels;

public class ClienteViewModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string TipoUsuario { get; set; }
    
    
    public static ClienteViewModel ToResponse(Cliente cliente)
    {
        return new ClienteViewModel
        {
            Id = cliente.Id,
            Nome = cliente.Nome,
            Email = cliente.Email,
            Telefone = cliente.Telefone,
            TipoUsuario = cliente.TipoUsuario
        };
    }
}