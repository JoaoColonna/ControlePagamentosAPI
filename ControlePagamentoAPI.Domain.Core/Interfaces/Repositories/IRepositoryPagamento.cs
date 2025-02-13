using ControlePagamentoAPI.Domain.Models;

namespace ControlePagamentoAPI.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryPagamento: IRepositoryBase<Pagamento>
    {
        Task<IEnumerable<Pagamento>> GetByClienteID(int clienteId);
    }
}
