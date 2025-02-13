using ControlePagamentoAPI.Domain.Models;

namespace ControlePagamentoAPI.Domain.Core.Interfaces.Services
{
    public interface IServicePagamento: IServiceBase<Pagamento>
    {
        Task<IEnumerable<Pagamento>> GetByClienteID(int id);
    }
}
