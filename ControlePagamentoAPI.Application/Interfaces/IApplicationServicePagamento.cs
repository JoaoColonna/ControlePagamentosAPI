using ControlePagamentoAPI.Application.DTO.DTOs;

namespace ControlePagamentoAPI.Application.Interfaces
{
    public interface IApplicationServicePagamento
    {
        void Add(PagamentoDTO obj);
        PagamentoDTO GetById(int id);
        void Dispose();
        Task<IEnumerable<PagamentoDTO>> GetByClienteId(int clienteId);
        void AtualizarStatus(int id, string novoStatus);
    }
}
