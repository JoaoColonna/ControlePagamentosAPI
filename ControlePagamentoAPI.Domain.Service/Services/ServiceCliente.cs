using ControlePagamentoAPI.Domain.Core.Interfaces.Repositories;
using ControlePagamentoAPI.Domain.Core.Interfaces.Services;
using ControlePagamentoAPI.Domain.Models;

namespace ControlePagamentoAPI.Domain.Service.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        public readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente RepositoryCliente)
            : base(RepositoryCliente)
        {
            _repositoryCliente = RepositoryCliente;
        }
    }
}
