using ControlePagamentoAPI.Domain.Models;
using ControlePagamentoAPI.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ControlePagamentoAPI.Infrastructure.Data.Repositories
{
    public class RepositoryPagamento : RepositoryBase<Pagamento>, IRepositoryPagamento
    {
        private readonly SqlContext _context;
        public RepositoryPagamento(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

        public async Task<IEnumerable<Pagamento>> GetByClienteID(int clienteId)
        {
            return await _context.Pagamentos.Where(p => p.ClienteId == clienteId).ToListAsync();
        }

    }
}
