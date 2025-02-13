using ControlePagamentoAPI.Domain.Core.Interfaces.Repositories;
using ControlePagamentoAPI.Domain.Models;

namespace ControlePagamentoAPI.Infrastructure.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _context;
        public RepositoryCliente(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
