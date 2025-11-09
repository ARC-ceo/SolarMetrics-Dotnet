using SolarMetrics.Web.Models;

namespace SolarMetrics.Web.Repositories;

public interface IClienteRepository
{
    Task<Cliente> AddAsync(Cliente cliente);
    Task<Cliente> GetByIdAsync(Guid id);
    Task DeleteAsync(Cliente cliente);
    Task SaveChangesAsync();
    Task<string> FindEmailAsync(string email, Guid? idToIgnore = null);
    Task<List<Cliente>> GetAllAsync();
}