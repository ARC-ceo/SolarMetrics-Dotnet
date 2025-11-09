using Microsoft.EntityFrameworkCore;
using SolarMetrics.Exceptions;
using SolarMetrics.Web.Models;
using SolarMetrics.Web.Repositories;

namespace SolarMetrics.Web.UseCase;


public class ClienteUseCase : IClienteUseCase
{
    private readonly IClienteRepository _clienteRepository;
    
    public ClienteUseCase(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    
    public async Task<Cliente> CreateAsync(Cliente cliente)
    {
        var existe = await _clienteRepository.FindEmailAsync(cliente.Email);
        if (existe != null)
            throw new EmailDuplicadoException();
        try
        {
            await _clienteRepository.AddAsync(cliente);
        }
        catch (DbUpdateException ex) 
            when (ex.InnerException?.Message.Contains("UNIQUE") == true)
        {
            throw new EmailDuplicadoException();
        }
        return cliente; 
    }

    public async Task<Cliente> UpdateAsync(Cliente cliente)
    {
        var clienteExistente = await GetById(cliente.Id);
        var result = await _clienteRepository.FindEmailAsync(cliente.Email,cliente.Id);
        if (result != null)
            throw new EmailDuplicadoException();
        
        clienteExistente.Nome = cliente.Nome;
        clienteExistente.Email = cliente.Email;
        clienteExistente.Telefone = cliente.Telefone;
        clienteExistente.TipoUsuario = cliente.TipoUsuario;
        
        try
        {
            await _clienteRepository.SaveChangesAsync();
        }
        catch (DbUpdateException ex) 
            when (ex.InnerException?.Message.Contains("UNIQUE") == true)
        {
            throw new EmailDuplicadoException();
        }
        return cliente; 
    }
    
    public async Task<Cliente> GetById(Guid id)
    {
        var cliente = await _clienteRepository.GetByIdAsync(id);
        if (cliente == null)
            throw new ClienteNaoEncontradoException();
        return cliente;
    }
    
    public async Task DeleteAsync(Guid id)
    {
        var cliente = await GetById(id);
        await _clienteRepository.DeleteAsync(cliente);
    }
    
    public async Task<List<Cliente>> GetAllAsync()
    {
        return await _clienteRepository.GetAllAsync();
    }
}