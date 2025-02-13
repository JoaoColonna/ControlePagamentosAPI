using ControlePagamentoAPI.Application.DTO.DTOs;
using ControlePagamentoAPI.Domain.Models;

namespace ControlePagamentoAPI.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperPagamento
    {
        #region Mappers

        Pagamento MapperToEntity(PagamentoDTO pagamentoDTO);
        IEnumerable<PagamentoDTO> MapperListPagamentos(IEnumerable<Pagamento> pagamentos);
        PagamentoDTO MapperToDTO(Pagamento pagamento);

        #endregion
    }

}
