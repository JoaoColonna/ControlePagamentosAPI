using ControlePagamentoAPI.Domain.Core.Interfaces.Repositories;
using ControlePagamentoAPI.Domain.Core.Interfaces.Services;
using ControlePagamentoAPI.Domain.Models;

namespace ControlePagamentoAPI.Domain.Service.Services
{
    public class ServicePagamento : ServiceBase<Pagamento>, IServicePagamento
    {
        public readonly IRepositoryPagamento _repositoryPagamento;

        public ServicePagamento(IRepositoryPagamento RepositoryPagamento)
            : base(RepositoryPagamento)
        {
            _repositoryPagamento = RepositoryPagamento;
        }

        public Task<IEnumerable<Pagamento>> GetByClienteID(int id)
        {
            return _repositoryPagamento.GetByClienteID(id);
        }
    }
}
