using SolarMetrics.Web.Models;

namespace SolarMetrics.Web.UseCase;

public interface IClienteUseCase
{
    Task<Cliente> CreateAsync(Cliente cliente);
    Task<Cliente> UpdateAsync(Cliente cliente);
    Task<Cliente> GetById(Guid id);
    Task<List<Cliente>> GetAllAsync();
    Task DeleteAsync(Guid id);
}