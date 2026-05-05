using Projeto1.Models;
namespace Projeto1.Interfaces

{    
public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> ListarTodosAsync();
        Task<Cliente?> ObterPorIdAsync(int id);
        Task IncluirAsync(Cliente cliente);
        Task AtualizarAsync(Cliente cliente);
        Task ExcluirAsync(int id);
    }
}