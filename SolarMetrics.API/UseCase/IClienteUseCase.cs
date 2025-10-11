using SolarMetrics.Infrastructure.Persistence.Entitites;

namespace SolarMetrics.UseCase;

public interface IClienteUseCase
{
    Task<Cliente> CreateAsync(Cliente cliente);
    Task<Cliente> UpdateAsync(Cliente cliente);
    Task<Cliente> GetById(Guid id);
    Task<List<Cliente>> GetAllAsync();
    Task DeleteAsync(Guid id);
}